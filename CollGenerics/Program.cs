namespace CollGenerics
{
    public class Program
    {
        public static void Main()
        {
            List<string> names = new();
            names.Add("Kevin");
            names.Insert(0, "Azubuike");
            names.Add("Okolie");
            names[0] = "Building";
            names.RemoveAt(0);

            Console.WriteLine($"First name: {names[0]}");

            IList<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FullName = "Okolie Azubuike Kevin"},
                new Customer {Id= 2, FullName = "Queen Pearl" },
                new Customer {Id =3,FullName = "David Chuwkwunonso Okolie"}
            };

            foreach (Customer cus in customers)
            {
                Console.WriteLine(cus.Id.ToString() + " " + cus.FullName);
                Console.ReadKey();
            }

            // Working with Dictionaries
            Dictionary<int, Customer> customer = new Dictionary<int, Customer>();

            Customer Alice = new Customer { Id = 1, FullName = "Jane Okara" };
            Customer Kennedy = new Customer { Id = 2, FullName = "Kennedy Ofia" };

            customer.Add(Alice.Id, Alice);
            customers[Kennedy.Id] = Kennedy;

            foreach (int key in customer.Keys)
            {
                Console.WriteLine(customer[key].FullName);
            }

            Dictionary<int, Customer> customer2 = new Dictionary<int, Customer>
            {
                [0] = new Customer { Id = 8, FullName = "Adaobi Joy" },
                [1] = new Customer { Id = 9, FullName = "Ekweren Mesahc" }
            };

            foreach (int key in customer2.Keys)
            {
                Console.WriteLine(customer2[key].FullName);
            }

        }
    }
}
