namespace CleanCode.OutputParameters;

public class Before
{
    public void DisplayCustomers()
    {
        int totalCount = 0;
        var customers = GetCustomers(1, out totalCount);

        Console.WriteLine("Total customers: " + totalCount);
        foreach (var c in customers)
            Console.WriteLine(c);
    }

    public IEnumerable<Customer> GetCustomers(int pageIndex, out int totalCount)
    {
        totalCount = 100;
        return new List<Customer>();
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
