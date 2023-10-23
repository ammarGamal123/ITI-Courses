namespace Day_12;

public abstract class GeoShape
{

    public int Dim1 { get; set; }
    public int Dim2 { get; set; }


    public GeoShape(int dim1 , int dim2)
    {
        Dim1 = dim1;
        Dim2 = dim2;
    }

    public abstract Double Area(); // Abstract Method = Virtual + No Implementation
    
    public abstract double Perimeter { get; /*set;*/ } // Abstract Readonly Property
    
}

abstract class RectBase : GeoShape
{

    public RectBase(int W = 0, int H = 0) : base(W, H)
    {
    }

    public override double Area()
    {
        return Dim1 * Dim2;
    }
    
}

class Rect : RectBase
{
    public override double Perimeter => (Dim1 * Dim2 * 2);
}

class Square : RectBase
{
    
    public override double Perimeter {
        get { return Dim1 * 4; }
    }

    public override double Area() => throw new NotImplementedException();
}
