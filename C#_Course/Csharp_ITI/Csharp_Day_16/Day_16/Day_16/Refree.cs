namespace Day_16;
// Subsc. 
public class Refree
{
    
    public string Name { get; set; }
    
    // Call Back Method 
    // Match Event Delegate Signature 

    public void Look()
    {
        Console.WriteLine($"Refree {Name} is Looking at Ball ");
    }
    public override string ToString()
    {
        return $"Name : {Name}";
    }
}