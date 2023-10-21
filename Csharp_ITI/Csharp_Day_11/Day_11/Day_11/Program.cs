namespace Day_11;
class Program
    {
        public static void Main()
        {
            
            #region Equals
            
            
            // Point p1 = new()
            // {
            //     X = 1 , Y = 2
            // };
            // Point p2 = new()
            // {
            //     X = 1 , Y = 2
            // };
            // Point p3 = p1;
            //
            // // p2 = default;
            //
            // if (p1.Equals(p2))
            //     Console.WriteLine("p1 EQ p2");
            // else 
            //     Console.WriteLine("p1 NEQ p2");
            // if (p1.Equals(p3))
            //     Console.WriteLine("p1 EQ p3");
            // else 
            //     Console.WriteLine("p1 NEQ p3");
            //
            // Point3D P3D = new Point3D()
            // {
            //     X = 1 , Y = 2 , Z = 143
            // };
            //
            //
            // if (p1.Equals(P3D))
            //     Console.WriteLine("P1 EQ P3D");
            // else
            //     Console.WriteLine("P1 NEQ P3D");
            
            #endregion

            
            #region Reference Equals
            
            // int X = 5;
            //
            // // Even though there is Must be Boxing but ReferenceEquals doesn't treat for value
            // Console.WriteLine(ReferenceEquals(X, X));
            
            #endregion

            Parent P = new Parent(1, 2);
            Console.WriteLine(P.Product());

            Child C = new Child(3, 4, 5);
            Console.WriteLine(C.Product()); // Derived 
            
            
            // Not Valid C# Code
            // Keyword base used only inside Derived Class not outside 
            // Console.WriteLine(C.base.Product());


        }
        
        
    }
