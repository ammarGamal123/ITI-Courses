namespace Day_08;

public interface IMyType
{
    void FunOne();
    
    decimal Salary { get; set; }
    
    
    // C# 8.0 Feature Default Implemented Methods
    // internal void FunTwo()
    // {
    //     Console.WriteLine("Inside Internal");
    // }
}

struct MyType : IMyType
{
    public void FunOne()
    {
        Console.WriteLine("My Type Fun One");  
    }

    public decimal Salary { get; set; }
}