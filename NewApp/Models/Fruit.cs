namespace NewApp.Models;
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
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3}", FruitID, Name, Color, Price);
        }
}