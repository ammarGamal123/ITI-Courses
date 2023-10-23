namespace Day_12;

public abstract class Person
{

    public string FName { get; set; }
    public string LName { get; set; }

    public Person(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }
    
    
    public override string ToString()
    {
        return $"{FName} :: {LName}";
    }
}