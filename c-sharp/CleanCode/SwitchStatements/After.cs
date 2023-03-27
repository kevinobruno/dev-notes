namespace CleanCode.SwitchStatements;

public class After
{
    public abstract class Customer
    {
        public abstract MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage);
    }

    public class PayAsYouGoCustomer : Customer
    {
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var statement = new MonthlyStatement
            {
                CallCost = 0.12f * monthlyUsage.CallMinutes,
                SmsCost = 0.12f * monthlyUsage.SmsCount
            };

            statement.TotalCost = statement.CallCost + statement.SmsCost;

            return statement;
        }
    }

    public class UnlimitedCustomer : Customer
    {
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var statement = new MonthlyStatement
            {
                TotalCost = 54.90f
            };

            return statement;
        }
    }

    public class MonthlyUsage
    {
        public int CallMinutes { get; set; }
        public int SmsCount { get; set; }
    }

    public class MonthlyStatement
    {
        public float CallCost { get; set; }
        public float SmsCost { get; set; }
        public float TotalCost { get; set; }
    }
}
