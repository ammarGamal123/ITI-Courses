namespace Day_11;


class Point3D : Point
{
    public int Z { get; set; }
    
}
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override bool Equals(object? obj)
    {
        // Point Right = (Point)obj; // UnSafe Casting

        // if (obj is Point)
        // {
        //     // is return false if casting will fail , no exception will be thrown
        //     Point Right = (Point)obj;
        //     return (X == Right.X && Y == Right.Y);
        // }

        // if (obj is Point Right)
        //     return (X == Right.X && Y == Right.Y);
        // return false;

        Point Right = obj as Point; // as return null if Casting fails , no exception will be thrown
        
        if (Right == null) return false;

        if (this.GetType() != obj.GetType())
            return false;
            

        if (ReferenceEquals(this , Right)) 
            return true;
        
        
        return (this.X == Right.X && this.Y == Right.Y);
    }

    public override string ToString()
    {
        return $"{X} , {Y}"; 
    }
}