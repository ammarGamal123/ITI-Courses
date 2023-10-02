namespace Day_05 {

    // struct temp
    // {
    //     
    // }
    class Program
    {
        
        public static void MainV1()
        {
            #region Casting Built in Value Types

            // int X = 50;
            // long Y = 5000;
            //
            // Y = X;
            // // Implicit Casting
            // // Int64 = Int32;
            // // Safe Casting , No RunTime Errors
            //
            // Console.WriteLine($"X = {X}");
            // Console.WriteLine($"Y = {Y}");
            //
            // Console.WriteLine("*******************************");
            //
            //
            // X = 50;
            // Y = 5000000000000000000;
            //
            // X = (int) Y;
            // // Int32 = Int64;
            // // UnSafe Casting 
            // // Default behavior for CLR , will not throw OverflowException when overflow happens 
            //
            //
            // // CLR will throw overflowException 
            // checked
            // {
            //     X = (int) Y;
            // }
            //
            //
            // Console.WriteLine($"X = {X}");
            // Console.WriteLine($"Y = {Y}");


            #endregion


            #region Boxing , UnBoxing

            // int X = 5;
            //
            // Object O1 = new Object();
            //
            //  O1 = X;
            // // Base Ref = Child = Valid Operation
            // // Safe 
            // // Boxing 
            // Console.WriteLine(O1);
            //
            // // O1 = "Hello";
            //
            // int Y = (int) O1;
            // // Derived = Base
            // // unSafe , Explicit
            // // UnBoxing  
            //
            // Console.WriteLine(Y);
            
            
            #endregion
            
            
            #region Nullable Types
            
            
            // int X = 50;
            // // X = null; Not Valid
            //
            // int? Y;
            // Y = 5000;
            // // Y = null ; // Valid
            //
            // Y = X;
            // // Safe Casting , Implicit
            //
            // // Y = null; There is a unExceptionHandling
            //
            // X = (int)Y;
            // // UnSafe , Explicit
            //
            // Console.WriteLine($"X = {X}");
            // Console.WriteLine($"Y = {Y}");
            //
            //
            // Y = null;
            //
            //
            // // Protective Programming
            //
            // // if (Y != null)
            // //     X = (int)Y;
            // // else
            // // {
            // //     X = 0;
            // // }
            // //
            //
            // // another way to protect your code against Nullable value
            //
            // // if (Y.HasValue)
            // //     X = Y.Value;
            // // else
            // //     X = 0;
            //
            //
            // // another way in a single line 
            //
            // // X = (Y.HasValue ? Y.Value : 0);
            //
            // X = Y ?? 0;
            //
            // Console.WriteLine($"X = {X}");
            // Console.WriteLine($"Y = {Y}");
            
            #endregion


            #region Null Operators
            
            // int[] Arr = default;
            //
            // // for (int i = 0; Arr != null &&  i < Arr.Length; i++)
            // // {
            // //     Console.WriteLine(Arr[i]);
            // // }
            //
            // // Null Propagation Operator / Null Conditional Operator 
            // for (int i = 0; i < Arr?.Length; i++)
            // {
            //     Console.WriteLine(Arr[i]);
            // }
            //
            // int R = Arr.Length; // UnSafe 
            // int? RR = Arr?.Length; // Safe Arr?.Length ==> (Arr != null) ? Arr.Length : null 
            // int RRR = Arr?.Length?? 0; // Safe
            //
            #endregion


            #region Implicit Local Typed Variable
            
            var D = 15.3;
            // Compiler will Detect Variable Data type
            // Based on Initial Value
            // Implicit Typed Local Variable
            // Can't be not Initialized 
            // Can't be Initialized with null 


            Console.WriteLine(D);
            
            // D = "Hello"; Not Valid
            #endregion
            
            
        }
    }
}