namespace CleanCode.DuplicatedCode;

class After
{
    class Time
    {
        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public int Hours { get; set; }
        public int Minutes { get; set; }

        public static Time Parse(string dateTime)
        {
            var hours = 0;
            var minutes = 0;

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

    public void AdmitGuest(string name, string admissionDateTime)
    {
        // Some logic 
        // ...

        var time = Time.Parse(admissionDateTime);

        // Some more logic 
        // ...
        if (time.Hours < 10)
        {

        }
    }

    public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
    {
        // Some logic 
        // ...
        var time = Time.Parse(admissionDateTime);

        // Some more logic 
        // ...
        if (time.Hours < 10)
        {

        }
    }
}
