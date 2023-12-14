using System.Linq.Expressions;

namespace Day_13;

 class Helper<T>
 where T : 
 // Primary   Constraints
 // 0:1 Zero or One
 // Special Primary Constraints 
 // class // T Must be Class
 // Special Primary Constraints
 // struct
 // Enum C# 7.X
 // Point // General Primary Constraints-class Name T: Point or Point Child
IComparable<T>
 // Secondary Constraints 
 // Interface Constraints
 // T must be Class / Struct Implementing IComparable
 // 0:* , Zero or Many
 
 
 //, new () // T data type having accessable paramterless ctor
 // can't use new () constraints with struct special primary constraints 
 // Ctor Constraints 
 // Till C# 9.0 only one Available Ctor Constraints 
 
{
    public Helper()
    {
        
    }

    




// public static T Sum(int x, int y) => x + y;

    public static void BSort(T[] Arr)
    {
        for (int i = 0; i < Arr?.Length; i++)
        {
            for (int j = 0; j < Arr.Length - i - 1; j++)
            {
                if (Arr[j].CompareTo(Arr[j + 1]) > 1)
                {
                    SWAP(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }
    }
    
    
    public int SearchArray(T[] Arr, T Value)
    {
        for (int i = 0; i < Arr?.Length; i++)
        {
            if (Arr[i].Equals( Value))
                return i;
        }
        return -1;
    }
    
    // Generic Method in Generic Class 
    public static void SWAP <T> (ref T  X , ref T  Y) // <T> Generic Method 
    {
        T temp = X;
        X = Y;
        Y = temp;
    }    
    
}