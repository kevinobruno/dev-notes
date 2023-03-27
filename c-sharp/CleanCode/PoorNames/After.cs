namespace CleanCode.PoorNames;

public class After
{
    public class Time
    {
        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public int Hours { get; set; }
        public int Minutes { get; set; }
    }

    public Time Parse(string dateTime)
    {
        int hours;
        int minutes;

        if (!string.IsNullOrWhiteSpace(dateTime))
        {
            int time;
            if (int.TryParse(dateTime.Replace(":", ""), out time))
            {
                hours = time / 100;
                minutes = time % 100;
            }
            else
            {
                throw new ArgumentException("dateTime");
            }
        }
        else
            throw new ArgumentNullException("dateTime");

        return new Time(hours, minutes);
    }
}
