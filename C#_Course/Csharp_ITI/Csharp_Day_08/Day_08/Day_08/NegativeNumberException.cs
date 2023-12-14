namespace Day_08;

public class NegativeNumberException:Exception
{
    public NegativeNumberException():base ("Number must be >= 0")
    {
        
    }
}