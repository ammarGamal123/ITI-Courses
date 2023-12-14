namespace LinqDay01;
// We use static because of using this in the function parameter
public static class Int32Extensions
{
    // Extension Method ===> this
    public static int mirror(this int i)
    {
        var Arr = i.ToString().ToCharArray();
        Array.Reverse(Arr);
        
        return int.Parse(new string(Arr));
    }
}