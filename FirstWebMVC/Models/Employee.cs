using System.Runtime.CompilerServices;

namespace FirstWebMVC.Models;

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
        try{
                //câu lệnh có thể gây ngoại lệ 
                Age = Convert.ToInt16(Console.ReadLine());
                Salary = Convert.ToDecimal(Console.ReadLine());
            }catch(Exception )
            {
                // câu lệnh xử lý ngoại lệ
                Age = 0;
            }
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}, EmployeeId, Fullname, Age, Salary");
    }
    public void Display5(string ten, string manhanvien , int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - ma nhan vien{1} - {2}tuoi ",ten, manhanvien, tuoi);
        }
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
}