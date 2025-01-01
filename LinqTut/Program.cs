using LinqTut;

public class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<Customer> customers = from cust in Company.Customers select cust;

        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.Name);
        }

        List<int> nums = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        foreach (int num in nums)
        {
            Console.WriteLine($"Numbers in nums are {num}");
        }

        List<Order> orders = new()
        {
             new Order  { CustomerId = 9, Description = "No addition" },
             new Order { CustomerId = 20, Description = "Bottle" },
             new Order { CustomerId = 30, Description = "Sneakers" }
        };

        IEnumerable<Order> orders1 = from ord in orders 
                                    // where ord.CustomerId == 20
                                     select ord;

        foreach (Order order in orders1)
        {
            Console.WriteLine($"Orders in list are {order.CustomerId} : {order.Description} ");
        }

        List<Customer> customers1 = new()
        {
            new Customer {Id = 1, Name = " Azubuike Okolie Kevin"},
            new Customer {Id = 2, Name = "Ijeoma Okolie Pearl"},
            new Customer {Id = 3, Name = " David Okolie Chukwunonso"}
        };

        IQueryable<Customer> customers2 = customers1.AsQueryable()
                                                    .Where(n => n.Id == 1);


        foreach (Customer cus1 in customers2)
        {
            Console.WriteLine(cus1.Id + cus1.Name);
        }
    }
}