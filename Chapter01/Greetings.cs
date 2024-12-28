using Chapter01;

class Greetings
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Colour = "Red";
        car1.Model = "Mazda";

        Console.WriteLine($"Car 1: {car1.Colour} {car1.Model}");
        car1.Drive();

        Car car2 = new()
        {
            Colour = "Blue",
            Model = "Toyota"
        };

        Console.WriteLine($"Car 2 Colour is {car2.Colour} and the model is {car2.Model}");
        car2.Drive();

        double a = 2.1;
        double b = 2.1;

        var calculate = Calc.Pythagorean(a, b);
        Console.WriteLine(calculate);

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}

