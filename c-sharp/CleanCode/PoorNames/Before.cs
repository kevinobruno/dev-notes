namespace CleanCode.PoorNames;

public class Before
{
    public class Abc
    {
        public Abc(int param1, int param2)
        {
            Param1 = param1;
            Param2 = param2;
        }

        public int Param1 { get; set; }
        public int Param2 { get; set; }
    }

    public Abc Method1(string d)
    {
        var h = 0;
        var m = 0;

        if (!string.IsNullOrWhiteSpace(d))
        {
            int t;
            if (int.TryParse(d.Replace(":", ""), out t))
            {
                h = t / 100;
                m = t % 100;
            }
            else
            {
                throw new ArgumentException("d");
            }
        }
        else
            throw new ArgumentNullException("d");

        return new Abc(h, m);
    }
}
