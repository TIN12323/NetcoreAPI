using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTT03.Models
{
    public class LopHoc
    {
        [Key]
        [Display(Name ="Mã Lớp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLop {get; set;}
        [Display(Name ="Tên Lớp")]
        [MaxLength(50)]
        public string TenLop {get; set;}
        public ICollection<SinhVien> SinhVien{get; set;}
    }
}