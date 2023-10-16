namespace Day_10;

// Container to Only Static Members
// No Objects can be Created from this class
// No Inheritance for Static Class
static class Utility
{
    // public int X { get; set; }
    // public int Y { get; set; }
    //
    // public Utility(int _X, int _Y)
    // {
    //     X = _X;
    //     Y = _Y;
    //    // pi = 3.14; Object Ctor is not the right place for Initializing Static Members 
    //     Console.WriteLine("Ctor");
    // }
    
    // Static Ctor 
    // will be executed only Once per class lifetime (Program)
    // Can't Specify return Datatype , Access Modifier or Input Parameter for static Ctor
    // cctor : static ctor in il
    // Max only one static ctor per class 

    static Utility()
    {
        Console.WriteLine("Static Ctor");
        pi = 3.14;
    }

    
    // why these Functions are "Static" ?
    // 1. These Funs don't depend on Attributes or Objects
    // 2. To Access this Funs without creating objects
    public static double Cm2Inch(double Cm)
    {
        return Cm / 2.54;
    }

    private static double pi;
    // Static Attribute Allocate in Heap before First Usage to Class till end of Program (or unreachable in case of reference Type) 
    // Static members initialized to default values by Default 
    public static double CircleArea(double radius)
    {
        return 2 * pi * (radius * radius); 
    }
    public static double Inch2Cm(double Inch)
    {
        return Inch * 2.54;
    }
}