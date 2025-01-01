namespace LinqTut
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
    }

    public static class Company
    {
        static Company()
        {
            Customers = new List<Customer>
            {
                new() { Id = 1, Name = "Kevin Okolie"},
                new Customer  { Id = 2, Name = "Azubuike Okolie"},
                new Customer  { Id = 3, Name = "David Okolie"}
            };

            Orders = new List<Order>
            {
                new Order {CustomerId = 1, Description = "Rice"},
                new Order {CustomerId = 2, Description = "Toyota Siennaa"},
                new Order {CustomerId = 3, Description = "Brabus"},
            };  
        }

        public static List<Customer> Customers { get; set; }
        public static List <Order> Orders { get; set; }
    }

}
