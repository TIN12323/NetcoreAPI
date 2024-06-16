using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models;
    public class Employee : Person
{
    public string? EmployeeId { get; set; }
    public int Age { get; set; }
}
