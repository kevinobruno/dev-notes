namespace CleanCode.VariableDeclarationsAtTheTop;

public class After
{
    private PayFrequency _payFrequency;

    public After(PayFrequency payFrequency)
    {
        _payFrequency = payFrequency;
    }

    public decimal CalcGross(decimal rate, decimal hours)
    {
        decimal overtimeHours = 0;
        decimal regularHours;

        switch (_payFrequency)
        {
            case PayFrequency.Fortnightly when hours > 80:
                overtimeHours = hours - 80;
                regularHours = 80;
                break;
            case PayFrequency.Fortnightly:
                regularHours = hours;
                break;
            case PayFrequency.Weekly when hours > 40:
                overtimeHours = hours - 40;
                regularHours = 40;
                break;
            case PayFrequency.Weekly:
                regularHours = hours;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        decimal overtimePay = 0;

        if (overtimeHours > 0m)
        {
            overtimePay += (rate * 1.5m) * overtimeHours;
        }

        var regularPay = (regularHours * rate);
        var grossPay = regularPay + overtimePay;

        return grossPay;
    }

    public enum PayFrequency
    {
        Weekly,
        Fortnightly
    }
}
