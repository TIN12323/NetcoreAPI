namespace FirstWebMVC.Models;
public class Giaiphuongtrinh
{

public class EquationSolver
{
    public static string Solvefirstorderequations(double a, double b)
    {
        if (a == 0)
        {
            return "Phương trình không phải là phương trình bậc nhất.";
        }
        double x = -b / a;
        return "Nghiệm của phương trình là: x = {x}";
    }

    public static string SolveQuadraticEquation(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            return "Phương trình không có nghiệm thực.";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return "Phương trình có nghiệm kép: x = {x}";
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return "Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Test phương trình bậc nhất
        Console.WriteLine("Giải phương trình bậc nhất: ");
        Console.WriteLine(EquationSolver.Solvefirstorderequations(2, 3)); // Ví dụ: 2x + 3 = 0

        // Test phương trình bậc hai
        Console.WriteLine("\nGiải phương trình bậc hai: ");
        Console.WriteLine(EquationSolver.SolveQuadraticEquation(1, -3, 2)); // Ví dụ: x^2 - 3x + 2 = 0
    }
}

}
