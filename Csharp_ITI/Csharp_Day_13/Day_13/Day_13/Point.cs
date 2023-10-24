namespace Day_13;

class Point3D : Point
{
    public int Z { get; set; }
    
}
public class Point : IComparable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }


    public override bool Equals(object obj)
    {
        #region Casting
        // Point Right = (Point)obj;

        if (obj is Point)
        {
            Point Right = (Point)obj;
            return (X == Right.X) && (Y == Right.Y);
        }
        
        if (obj is Point Right)
            return (X == Right.X && Y == Right.Y);
        return false;

        #endregion

        Point Right = obj as Point; // as return null if casting fails , no exception will be thrown
        if (Right == null) return false;
        if (this.GetType() != Right.GetType()) return false;
        if (object.ReferenceEquals(this, Right)) return true;
        
        return (X == Right.X && Y == Right.Y);
    }

    public override string ToString()
    {
        return $"{X} , {Y}";
    }

    public int CompareTo(Point? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var xComparison = X.CompareTo(other.X);
        if (xComparison != 0) return xComparison;
        return Y.CompareTo(other.Y); 
    }
}
