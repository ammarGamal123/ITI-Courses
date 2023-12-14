namespace Day_16;
// Subsc.
public class Player
{ 
    
    public string Name { get; set; }
    
    public string Team { get; set; }
    
    // Call Back Method 
    // Match event Delegate Signature

    public void Run()
    {
        Console.WriteLine($"Player {Name} is Running ......");
    }
    
    
    
    public override string ToString()
    {
        return $"Player : {Name} , Team : {Team}";
    }
}