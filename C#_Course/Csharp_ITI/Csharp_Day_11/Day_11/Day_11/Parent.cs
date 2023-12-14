namespace Day_11;

public class Parent
{
    public int X { get; protected set; }

    public int Y { get; protected set; }

    public Parent(int _X , int _Y)
    {
        X = _X;
        Y = _Y;
        Console.WriteLine("Base Ctor");
    }

    public int Product()
    {
        return X * Y;
    }
    
    public override string ToString()
    {
        return $"{X} :: {Y}";
    }
}

public class Child : Parent
{
    public int Z { get; protected set; }

    public Child(int _X , int _Y , int _Z)
    :base (_X , _Y) // Base Ctor Chaining 
    {
        Z = _Z;
        Console.WriteLine("Child Ctor");
    }
    
    // "new" keyword not necessary 
    public new int Product()
    {
        // base.Product() = X * Y
     // return 
        return Z * base.Product();
        // return Z * X * Y;
    }
    public override string ToString()
    {
        return $"{X} :: {Y} :: {Z}";
    }
}