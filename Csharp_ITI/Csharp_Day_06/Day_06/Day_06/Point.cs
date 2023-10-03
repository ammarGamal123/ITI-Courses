namespace Day_06;

public struct Point
{
    private int X;
    private int Y;


    public Point(int _X , int _Y)
    {
        // Any userdefined Ctor in Struct 
        // Ctor must fully initialized all Struct Attributes 
        X = _X;
        Y = _Y;
    }

    public Point(int N)
    {
        X = Y = N;
    }
    
    // Compiler will always Generate Parameterless Ctor
    // to initialize all Members with default value
    // Struct can't have explicit Parameterless Ctor


    public Point()
    {
        X = Y = 0; 
    }
    public override string ToString()
    {
        return $"X = {X} , Y = {Y}";
    }
}