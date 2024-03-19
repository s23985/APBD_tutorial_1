// See https://aka.ms/new-console-template for more information

namespace APBD_tutorial_01;

public class Program
{
    public static void Main()
    {
        for (var i = 0; i < 3; i++)
        {
            Console.WriteLine("Hello, World!");
        }

        var arr = new[] {1, 2, 3, 4, 5, 6};
        
        Console.WriteLine(CalculateAverage.Calculate(arr));
        
        Console.WriteLine(CalculateMax.Calculate(arr));
    }
}