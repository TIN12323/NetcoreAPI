namespace NewApp.Models;
public class Student
{
    public string? StudentId {get; set;}
    public string? Fullname {get; set;}
    public int Age {get; set;}
    public string? Major {get; set;} 
    public void EnterData()
    {
        System.Console.WriteLine("StudentId =");
        StudentId = Console.ReadLine();
        System.Console.WriteLine("FullName =");
        Fullname = Console.ReadLine();
        System.Console.WriteLine("Age =");
        Age = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Major =");
        Major = Console.ReadLine();
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}", StudentId, Fullname, Age, Major);
    }
}