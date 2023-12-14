namespace Csharp
{
    class Program
    {
        public static void Main()
        {
            #region value type

            int x = 5;
            int y;
            y = x;
            ++x;
            Console.WriteLine(y);
            Console.WriteLine(x);
            #endregion
            
            
            #region reference type

            Object o;
            // Zero bytes have been allocated
            o = new object();
            /*
             * new (IL newObj)
             * 1.Allocate Required # of Bytes in Heap
             * (Object Size + CLR Overhead Variable
             *
             * 2. Initialize (cross out) allocated Bytes
             *
             * 3. Call userdefined Ctor if exists
             *
             * 4. Assign Reference to newly allocated Object
             */
            
            object o2 = new object();
            // primary key = object identity for the object 
            Console.WriteLine(o.GetHashCode());
            Console.WriteLine(o2.GetHashCode());
            
            
            o2 = o;
            
            // After Equality
            Console.WriteLine("After Equality : ");
            Console.WriteLine(o.GetHashCode());
            Console.WriteLine(o2.GetHashCode());
            
            
            #endregion

        }
    }
}