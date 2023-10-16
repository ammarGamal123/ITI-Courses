namespace Day_10;

public class Employee
{

    private int id;

    public int ID
    {
        get { return id; }
        internal set { id = value; }
    }

    private string name;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Salary { get; set; } 
    // Automatic Property
    // Compiler will generate a hidden (private) Attribute and encapsulate it with Public Property 

    public override string ToString()
    {
        return $"{id} :: {name} :: {Salary}";
        // Here is a problem in ==> Salary Call it will take more time than if I make an Attribute = salary 
    }
    
}