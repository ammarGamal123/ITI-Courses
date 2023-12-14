namespace Day_16;

public struct Location
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return $"X = {X} , Y = {Y} , Z = {Z}";
    }

    public static bool operator ==(Location L, Location R)
    {
        return L.X == R.X && L.Y == R.Y && L.Z == R.Z;
    }

    public static bool operator !=(Location L, Location R)
    {
        return L.X != R.X || L.Y != R.Y || L.Z != R.Z;
    }
}