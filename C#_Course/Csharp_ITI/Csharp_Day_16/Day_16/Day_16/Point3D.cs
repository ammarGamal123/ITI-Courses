using System.Threading.Channels;

namespace Day_16;

public class Point3D
{
    private int x;
    private int y;
    private int z;
    
    public int X
    {
        get => x; 
        set => x = value;
    }

    public int Y
    {
        get => y;
        set => y = value;
    }

    public int Z
    {
        get => z;
        set => z = value;
    }

    public string readOnlProp => "Test";
    
    
    public Point3D() => Console.WriteLine("Paratmerless Ctor");
    

    public override string ToString()
    {
        return $"{x} , {y} , {z}";
    }
}