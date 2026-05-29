using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLSV.Core.Helpers;

namespace QLSV.Core.Tests
{
    [TestClass]
    public class CryptoHelperTests
    {
        [TestMethod]
        public void HashUsername_WithSameInput_IsDeterministic()
        {
            var h1 = CryptoHelper.HashUsername("Admin");
            var h2 = CryptoHelper.HashUsername(" admin ");
            Assert.AreEqual(h1, h2);
        }

        [TestMethod]
        public void HashPassword_AndVerifyPassword_ShouldPass()
        {
            var hash = CryptoHelper.HashPassword("StrongPass123!");
            Assert.IsTrue(CryptoHelper.VerifyPassword("StrongPass123!", hash));
        }

        [TestMethod]
        public void VerifyPassword_WithWrongPassword_ShouldFail()
        {
            var hash = CryptoHelper.HashPassword("StrongPass123!");
            Assert.IsFalse(CryptoHelper.VerifyPassword("WrongPass", hash));
        }

        [TestMethod]
        public void EncryptDecrypt_RoundTrip_ShouldMatch()
        {
            const string text = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLSV_MRBEAST;";
            var cipher = CryptoHelper.Encrypt(text);
            var plain = CryptoHelper.Decrypt(cipher);
            Assert.AreEqual(text, plain);
        }

        [TestMethod]
        public void ResolveConnectionString_WithPlainText_ReturnsOriginal()
        {
            const string text = "Server=.\\SQLEXPRESS;Database=QLSV_MRBEAST;";
            Assert.AreEqual(text, CryptoHelper.ResolveConnectionString(text));
        }
    }
}
