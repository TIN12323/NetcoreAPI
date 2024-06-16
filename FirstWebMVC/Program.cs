
using FirstWebMVC.Models;
 public class Program
 {
    private static void Main (string[] args)
    {
        {
            Students std = new Students();
            std.EnterData();
            std.Display();
        }
        // khoi tao 2 doi tuong tu class Person
        Person ps1 = new Person();
        SinhVien ps2 = new SinhVien();
        Student ps3 = new Student();
        Employee ps4 = new Employee();
        Fruit ps5 = new Fruit();
        // gan gia tri cho thuoc tinh doi tuong ps1,ps2
        ps1.FullName = " Hoang Trung Tin";
        ps1.Address = " Nam Dinh";
        ps1.Age = 21;
        ps2 .FullName = " Hoang Trung Tin";
        ps2.Address = " Nam Dinh";
        ps2.Age = 21;
        ps2.PhoneNumber = 0961156782;
        ps3.StudentId = "2121051334";
        ps3.Fullname = " Hoang Trung A";
        ps3.Age = 22;
        ps3.Major = "CNTT";
        ps4.EmployeeId = "MA20";
        ps4.FullName = " Hoang Trung B";
        ps4.Age = 23;
        ps4.Salary = 1000000;
        ps5.FruitID = "CT300Qz";
        ps5.Name = "Apple";
        ps5.Color = "Red";
        ps5.Price = 200000;
        
        // khai bao 2 bien so va gan gia tri cua class Person
        string str = "Hoang Trung Tin";
        int a = 21;
        Console.WriteLine("{0} sinh nam {1}",str,ps1.GetYearOfBirth(a));
        // khai bao 3 bien so va gan gia tri cua class Student
        string cmd = "Hoang Trung A";
        string htm = "212101334";
        int b = 22;
        Console.WriteLine("{0} sinh nam {1}",str,ps3.GetYearOfBirth(a));
        // khai bao 2 bien so va gan gia tri cua class Fruit
        string htt = "Apple";
        string kkc = " Red";
        Console.WriteLine("{0} sinh nam {1}",str,ps5.GetReadingthecolor(a));
        // khai bao 3 bien so va gan gia tri cua class Employee
        string acc = "Hoang Trung B";
        string acb = " MA20";
        int c = 23;
        Console.WriteLine("{0} sinh nam {1}",str,ps4.GetYearOfBirth(a));
        // goi phuong thuc hien thi thong tin
        ps1.Display();
        ps2.Display();
        ps3.Display();
        ps4.Display();
        ps5.Display();

        // goi phuong thuc va truyen tham so
        ps1.Display2(str , a);
        ps3.Display3(cmd,htm, b);
        ps5.Display4(htt,kkc);
        ps4.Display5(acc,acb,c);

    
    }
 }