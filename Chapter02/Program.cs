namespace Chapter02
{
    public class Chapter02
    {
        static void Main()
        {
            Console.WriteLine("Hello");
            PriceChecker();
        }
    


        private static void PriceChecker()
        {
            double price = 0;
            string response = price == 0 ? "Sell" : "Buy";

            Console.WriteLine(response);
        }
    }
}