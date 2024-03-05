using System.Runtime.CompilerServices;

namespace NewApp.Models;

public class Employee
{
    public string? EmployeeId { get; set;}
    public string? FullName { get; set;}
    public int Age { get; set;}
    public decimal Salary { get; set;}
    public void EnterData()
    {
        System.Console.Write("EmployeeId = ");
        EmployeeId = Console.ReadLine();
        System.Console.Write("FullName =");
        FullName = Console.ReadLine();
        System.Console.Write("Age=");
        Age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Salary =");
        Salary = Convert.ToDecimal(Console.ReadLine());
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}, EmployeeId, Fullname, Age, Salary");
    }
}