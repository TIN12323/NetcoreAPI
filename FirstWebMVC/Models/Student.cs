namespace FirstWebMVC.Models;
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
        try{
                //câu lệnh có thể gây ngoại lệ 
                Age = Convert.ToInt16(Console.ReadLine());
            }catch(Exception )
            {
                // câu lệnh xử lý ngoại lệ
                Age = 0;
            }
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}", StudentId, Fullname, Age, Major);
    }
    public void Display3(string ten ,string masinhvien, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - ma sinh vien{1} -{2}  - ",ten,masinhvien, tuoi);
        }
    public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
}