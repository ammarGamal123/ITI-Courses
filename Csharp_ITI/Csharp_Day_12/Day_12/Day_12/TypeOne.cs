namespace Day_12;


// Can't inherit from sealed class
public sealed class TypeOne
{
    
}

// class TypeOneOne : TypeOne
// {
//     
// }

public class Type2
{
    public int X { get; set; }

   // public sealed void MyFun(){....} // Not Valid 
    
}

abstract class Type3
{
    public int X { get; set; }

    public abstract void MyFun();
}

class Type31 : Type3
{
    public sealed override void MyFun() // Valid   
    {
        Console.WriteLine($"Type 3 {X}");
    }
}