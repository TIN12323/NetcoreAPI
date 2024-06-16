using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangTrungTin2121051334.Models
{
    public class LopHoc
    {
        [Key]
        [Display(Name = "Mã Lớp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Malop {get; set;}
        [MaxLength(50)]
        [Display(Name = "Tên Lớp")]
        public string TenLop{get; set;}
    }
}