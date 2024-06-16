namespace FirstWebMVC.Models;
public class Fruit
{
    public string? FruitID { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public void EnterData()
        {
           Console.Write("Fruit ID = ");
            FruitID = Console.ReadLine();
            
            Console.Write("Name = ");
            Name = Console.ReadLine();
            
            Console.Write("Color = ");
            Color = Console.ReadLine();
            
            Console.Write("Price = ");
            Price = Convert.ToDecimal(Console.ReadLine());
            try{
                //câu lệnh có thể gây ngoại lệ 
                Price  = Convert.ToDecimal(Console.ReadLine());
            }catch(Exception )
            {
                // câu lệnh xử lý ngoại lệ
                Price = 200000;
            }
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3}", FruitID, Name, Color, Price);
        }
        public void Display4(string ten ,string mausac)
        {
            System.Console.WriteLine("ten {0} - mausac{1}  ",ten,mausac);
        }
    public int GetReadingthecolor (int color)
        {
            int Readingthecolor =  1 - color  ;
            return Readingthecolor;
        }
}