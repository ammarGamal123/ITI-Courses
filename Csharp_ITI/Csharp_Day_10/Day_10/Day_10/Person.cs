namespace Day_10;

public class Person
{
    public string FName { get; set; }
    public string LName { get; set; }

    public static explicit operator Person(Employee E)
    {
        var Names = E.Name.Split(' ');
        return new()
        {
            FName = Names[0] , LName = Names[1]
        };
    }

    public override string ToString()
    {
        return $"First Name :: {FName} \nLast Name :: {LName}";
    }
}