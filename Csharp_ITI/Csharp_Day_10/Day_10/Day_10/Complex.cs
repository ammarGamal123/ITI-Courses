namespace Day_10;

public class Complex
{
    public int Real { get; set; }
    public int Imag { get; set; }

    #region Operator Overloading
    // Must be Static Member Functions  
    // Can't overlaod [] or = 

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex()
        {
            Real = (c1?.Real??0) + (c2?.Real??0),
            Imag = (c1?.Imag??0) + (c2?.Imag??0)
        };
    }

    public static Complex operator +(Complex c1, int val)
    {
        return new Complex()
        {
            Real = (c1?.Real??0) + val ,
            Imag = (c1?.Imag??0)
        };
    }
    
    // in C# Can't Explicitly Overload Compund Operators (+= , -= , *= , ...)
    // if you overload Original Operator (+) , Compund Operator will be supported by default 
    
    // public static Complex operator += (Complex c1, Complex c2)
    // {
    //     return new Complex()
    //     {
    //
    //     };
    // }

    // Cater for Both Prefix , Postfix Versions
    public static Complex operator -(Complex c)
    {
        return new Complex()
        {
            Real = (c?.Real ?? 0) * -1,
            Imag = (c?.Imag ?? 0) * -1
        };
    }
    
    
    public static Complex operator ++(Complex c)
    {
        return new Complex()
        {
            Real = (c?.Real ?? 0) + 1 , Imag = (c?.Imag ?? 0)
        };
    }
    
    
    // Comparison Operators Comes in Pairs 
    public static bool operator >(Complex c1 , Complex c2)
    {
        if (c1.Real == c2.Real)
            return c1.Imag > c2.Imag;

        return c1.Real > c2.Real;
    }
    public static bool operator < (Complex c1 , Complex c2)
    {
        if (c1.Real == c2.Real)
            return c1.Imag < c2.Imag;

        return c1.Real < c2.Real;
    }
    public static bool operator >=(Complex c1 , Complex c2)
    {
        if (c1.Real == c2.Real)
            return c1.Imag >= c2.Imag;

        return c1.Real >= c2.Real;
    }
    public static bool operator <=(Complex c1 , Complex c2)
    {
        if (c1.Real == c2.Real)
            return c1.Imag <= c2.Imag;

        return c1.Real <= c2.Real;
    }
    
    
    
    // Casting Operators
    public static implicit operator int (Complex c)
    {
        return c?.Real ?? 0;
    }

    public static explicit operator string(Complex c)
    {
        return c?.ToString() ?? "NA";
    }
    
    #endregion
    public override string ToString()
    {
        return $"{Real} + {Imag}i";
    }
}