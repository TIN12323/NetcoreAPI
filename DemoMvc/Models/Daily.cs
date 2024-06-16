using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models;

    public class Daily
    {
        [Key]
        public string? HeThongPhanPhoi { get; set; }
        public string? MaDaiLy { get; set; }
        public string? TenDaiLy { get; set; }
        public string? DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public string? DienThoai  { get; set; }
        public string? MaHTPP { get; set; }

    }
