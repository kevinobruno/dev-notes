namespace CleanCode.OutputParameters;

public class After
{
    public class GetCustomersResult
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }

    public void DisplayCustomers()
    {
        const int pageIndex = 1;
        var result = GetCustomers(pageIndex);

        Console.WriteLine("Total customers: " + result.TotalCount);
        foreach (var c in result.Customers)
            Console.WriteLine(c);
    }

    public GetCustomersResult GetCustomers(int pageIndex)
    {
        var totalCount = 100;
        return new GetCustomersResult() { TotalCount = totalCount, Customers = new List<Customer>()};
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
