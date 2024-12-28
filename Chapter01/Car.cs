using static System.Math;
namespace Chapter01
{
    public class Car
    {
        public string Colour { get; set; }
        public string Model { get; set; }

        public void Drive() 
        {
                Console.WriteLine($"{Model} is { Colour}");
        }
    }

    public class Calc
    {
        public static double Pythagorean( double x, double y)
        {
            double cSqured = Pow(x, 2) + Pow(y, 2);
            return Sqrt(cSqured);
        }
    }
}
