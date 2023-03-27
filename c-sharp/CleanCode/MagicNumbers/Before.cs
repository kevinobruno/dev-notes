namespace CleanCode.MagicNumbers;

public class Before
{
    public void ApproveDocument(int status)
    {
        if (status == 1)
        {
            // ...
        }
        else if (status == 2)
        {
            // ...
        }
    }

    public void RejectDoument(string status)
    {
        switch (status)
        {
            case "1":
                // ...
                break;
            case "2":
                // ...
                break;
        }
    }
    
    public enum DocumentStatus
    {
        Draft = 1,
        Lodged = 2
    }
}
