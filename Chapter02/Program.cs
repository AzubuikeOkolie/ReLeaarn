namespace Chapter02
{
    public class Chapter02
    {
        static void Main()
        {
            Console.WriteLine("Hello");

            BuySell.PriceChecker();
        }
    }

    public class BuySell()
    {
        public static void PriceChecker()
        {
            double price = 0;
            string response = price == 0 ? "Sell" : "Buy";

            Console.WriteLine(response);
        }
    }
}