using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTT03.Models
{
    public class SinhVien
    {
        [Key]
        [Display(Name ="Mã Sinh Viên")]
        [MaxLength(20)]
        public string MaSinhVien {get; set;}
        [Display(Name ="Họ tên")]
        [MaxLength(50)]
        public string HoTen {get; set;}
        [Display(Name ="Mã Lớp")]
        [ForeignKey("MaLop")]
        public  int? MaLop {get; set;}
        [Display(Name ="Lớp học")]
        public LopHoc? LopHoc{get; set; }
    }
}