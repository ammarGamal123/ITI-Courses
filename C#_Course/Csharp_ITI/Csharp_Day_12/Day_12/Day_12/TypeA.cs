namespace Day_12;

public class TypeA
{
    public int A { get; set; }


    public TypeA(int _A = 0)
    {
        A = _A;
    }

    public void staticallyBindedShow()
    {
        Console.WriteLine("I am Base");
    }
    
    // Dynamically Binded 

    internal virtual void DynShow() // non Private Virtual Method 
    {
        Console.WriteLine($"Base {A} ");
    }
}

public class TypeB : TypeA
{
    public int B { get; set; }

    
    public TypeB(int _A = 0 , int _B = 0) : base (_A)
    {
        B = _B;
    }

    public new void staticallyBindedShow()
    {
        Console.WriteLine("I am Derived");
    }

    internal override void DynShow()
    {
        Console.WriteLine($"Derived :: {A} :: {B}");
    }
}

public class TypeC : TypeB
{
    
    public int C { get; set; }


    public TypeC(int _A = 0 , int _B = 0 , int _C = 0) : base(_A , _B)
    {
        C = _C;
    }

    internal override void DynShow()
    {
        Console.WriteLine($"Type C {A} :: {B} :: {C}");
    }
    
}

public class TypeD : TypeC
{
    
    
    // new Implementation for DynShow Function
     
    
    
    internal new virtual void DynShow() // new dynamically binded implementation
        
    // internal new /*virtual*/ void DynShow() // new statically binded implementation
    {
        Console.WriteLine("Type D");
    }
}