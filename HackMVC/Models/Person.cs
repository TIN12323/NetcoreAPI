using System.ComponentModel.DataAnnotations;

namespace HackMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Address { get; set;}
    }
}