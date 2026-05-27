namespace QLSV.Core.Models
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }

        public override string ToString() => string.IsNullOrEmpty(TenLop) ? MaLop : $"{MaLop} - {TenLop}";
    }
}
