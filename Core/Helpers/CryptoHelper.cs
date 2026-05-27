using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace QLSV.Core.Helpers
{
    public static class CryptoHelper
    {
        private const int Pbkdf2Iterations = 10000;
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const string EncPrefix = "ENC:";

        public static string EncryptionKey =>
            ConfigurationManager.AppSettings["EncryptionKey"] ?? "QLSV_TDMU_SecretKey_2026!";

        public static string HashUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return null;
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(username.Trim().ToLowerInvariant()));
                return BytesToHex(bytes);
            }
        }

        public static string HashPassword(string password)
        {
            var salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(salt);

            var hash = DeriveKey(password, salt);
            return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(storedHash))
                return false;

            var parts = storedHash.Split('.');
            if (parts.Length != 2) return false;

            byte[] salt, expected;
            try
            {
                salt = Convert.FromBase64String(parts[0]);
                expected = Convert.FromBase64String(parts[1]);
            }
            catch
            {
                return false;
            }

            var actual = DeriveKey(password, salt);
            return SlowEquals(expected, actual);
        }

        public static string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return plainText;

            using (var aes = Aes.Create())
            {
                aes.Key = DeriveAesKey(EncryptionKey);
                aes.GenerateIV();
                using (var enc = aes.CreateEncryptor())
                {
                    var plain = Encoding.UTF8.GetBytes(plainText);
                    var cipher = enc.TransformFinalBlock(plain, 0, plain.Length);
                    return $"{EncPrefix}{Convert.ToBase64String(aes.IV)}:{Convert.ToBase64String(cipher)}";
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText) || !cipherText.StartsWith(EncPrefix, StringComparison.Ordinal))
                return cipherText;

            var payload = cipherText.Substring(EncPrefix.Length);
            var sep = payload.IndexOf(':');
            if (sep < 0) throw new InvalidOperationException("Chuỗi mã hóa connection string không hợp lệ.");

            var iv = Convert.FromBase64String(payload.Substring(0, sep));
            var cipher = Convert.FromBase64String(payload.Substring(sep + 1));

            using (var aes = Aes.Create())
            {
                aes.Key = DeriveAesKey(EncryptionKey);
                aes.IV = iv;
                using (var dec = aes.CreateDecryptor())
                {
                    var plain = dec.TransformFinalBlock(cipher, 0, cipher.Length);
                    return Encoding.UTF8.GetString(plain);
                }
            }
        }

        public static string ResolveConnectionString(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return raw;
            return raw.StartsWith(EncPrefix, StringComparison.Ordinal) ? Decrypt(raw) : raw;
        }

        private static byte[] DeriveKey(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Pbkdf2Iterations))
                return pbkdf2.GetBytes(HashSize);
        }

        private static byte[] DeriveAesKey(string secret)
        {
            using (var sha = SHA256.Create())
                return sha.ComputeHash(Encoding.UTF8.GetBytes(secret));
        }

        private static string BytesToHex(byte[] bytes)
        {
            var sb = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            var diff = 0;
            for (int i = 0; i < a.Length; i++)
                diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
