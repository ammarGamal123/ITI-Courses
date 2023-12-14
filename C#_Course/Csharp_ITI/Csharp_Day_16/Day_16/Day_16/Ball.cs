namespace Day_16;
// Publisher Class 
public class Ball
{
    public int ID { get; set; }

    private Location ballLocation;


    internal Location BallLocation
    {
        get => ballLocation;
        set
        {
            if (ballLocation != value)
            {
                ballLocation = value;
                // Notify Subs.
                BallLocationChanged?.Invoke();
                // Loop Through Invocation List
                // Call Subsc. Call Back Method 
            }
        }
    } 
    
    // 1. event Declaration 
    public event Action BallLocationChanged;
    

    public override string ToString()
    {
        return $"Ball ID = {ID} @ {ballLocation}";
    }
}