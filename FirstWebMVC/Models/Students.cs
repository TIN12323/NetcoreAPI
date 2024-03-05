using System;
namespace FirstWebMVC.Models;
    public class Students : Person
    {
        public string? StudentCode{get; set;}
        public new void EnterData()
        {
            //ke thua lai phuong thuc o class Person
            base.EnterData();
            //phat trien them nhap thong tin Student Code
            StudentCode = Console.ReadLine();
        }
        public new void Display ()
        { 
            //ke thua lai phuong thuc o class Person
            base.Display();
            //phat trien hien thi nhap thong tin Student Code
            System.Console.Write("- Ma sinh vien: {0}", StudentCode);
        }
    } 

