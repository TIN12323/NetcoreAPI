using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTT1.Models
{
    public class SinhVien
    {
        [Key]
        [Display(Name ="Mã Sinh Viên")]
        [MaxLength(20)]
        public string MaSinhVien{get; set;}
        [Display(Name ="Họ Tên")]
        [MaxLength(50)]
        public string HoTen {get; set;}
        [ForeignKey("MaLop")]
        public int MaLop{get;set;}
        [Display(Name ="Lớp Học")]
        public LopHoc? LopHoc{get;set;}
    }
}