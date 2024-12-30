namespace Chapter02
{
    public class Chapter02
    {
        static void Main()
        {
            Console.WriteLine("Hello");

            BuySell.PriceChecker();

            CollectionExamples collectionExamples = new();
            collectionExamples.Chapter02Collections();

            Calculator.Calculate();
        }
    }

    public class BuySell
    {
        public static void PriceChecker()
        {
            double price = 0;
            string response = price == 0 ? "Sell" : "Buy";

            Console.WriteLine(response);
        }
    }

    public class CollectionExamples
    {
        public void Chapter02Collections()
        {
            int[] oddNumbers = { 1, 2, 3 };

            int firstNumber = oddNumbers[0];
            int lastNumber = oddNumbers[2];

            string[] colors = { "red", "green", "blue" };

            string[] colours = new string[3];
            colours[0] = "red";
            colours[1] = "green";
            colours[2] = "yellow";

            List<int> oddNumber = [1, 3, 5, 7, 9, 11];
            List<int> evenNumbers = new List<int> { 1, 4, 5, 5, 6 };


            int firstEvenNumber = evenNumbers[0];

            List<int[]> evenNumbes = new()
            {
                new int[] { 2, 4, 6 },
                new int[] { 8, 10, 12 }
            };

            double[] tempreatures = {34.2, 45.7, 34.0, 24.45 };
            for (int i = 0; i < tempreatures.Length; i++) 
            {
                Console.WriteLine(i);
            }

            foreach (int temperature in tempreatures) 
            {
                Console.WriteLine(temperature);
            }
            Console.ReadKey();
        }
    }
}