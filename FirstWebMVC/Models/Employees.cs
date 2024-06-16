namespace FirstWebMVC.Models;
    public class Employees : Person
    {
        public string? EmployeeCode{get; set;}
        public new void EnterData()
        {
            //ke thua lai phuong thuc o class Person
            base.EnterData();
            //phat trien them nhap thong tin EmployeeCode
            EmployeeCode = Console.ReadLine();
        }
        public new void Display ()
        { 
            //ke thua lai phuong thuc o class Person
            base.Display();
            //phat trien hien thi nhap thong tin Student Code
            System.Console.Write("- Ma sinh vien: {0}", EmployeeCode);
        }
    } 