namespace Day_13
{
    class Program
    {
        public static void Main()
        {
            
            #region Generic Method 

            int A = 7, B = 3;
            Helper.SWAP(ref A, ref B); // Non Generic Function
            Helper.SWAP<int>(ref A, ref B); // Call Generic Function Explicitly Define T
            
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            
            
            double d1 = 1.32, d2 = 32.21;
            Helper.SWAP(ref d1 , ref d2); // In Case of Generic Method (Not Generic ..
            // Class , Struct , Interface)
            // Compiler Can Detect Type Parameter T Type from input Parameter
            
            Console.WriteLine($"D1 = {d1}");
            Console.WriteLine($"D2 = {d2}");
            
            
            string str1 = "abc", str2 = "xyz";
            Helper.SWAP(ref str1 , ref str2);
            Console.WriteLine($"Str1 = {str1}");
            Console.WriteLine($"Str2 = {str2}");
            
            
            Point p1 = new Point()
            {
                X = 10 , Y = 20
            };
            
            Point p2 = new Point()
            {
                X = 30, Y = 40
            };
            Helper.SWAP(ref p1, ref p2);
            Console.WriteLine($"P1 = {p1}");
            Console.WriteLine($"P2 = {p2}");
            
            #endregion
            
            
            int A = 7, B = 3;
            // Helper.SWAP(ref A, ref B); // Non Generic Function
            Helper<int>.SWAP(ref A, ref B); // Call Generic Function Explicitly Define T
            
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            
            
            double d1 = 1.32, d2 = 32.21;
            Helper<double>.SWAP(ref d1 , ref d2); // In Case of Generic Method (Not Generic ..
            // Class , Struct , Interface)
            // Compiler Can Detect Type Parameter T Type from input Parameter
            
            Console.WriteLine($"D1 = {d1}");
            Console.WriteLine($"D2 = {d2}");
            
            
            string str1 = "abc", str2 = "xyz";
            Helper<string>.SWAP(ref str1 , ref str2);
            Console.WriteLine($"Str1 = {str1}");
            Console.WriteLine($"Str2 = {str2}");
            
            
            Point p1 = new Point()
            {
                X = 10 , Y = 20
            };
            
            Point p2 = new Point()
            {
                X = 30, Y = 40
            };
            Helper<Point>.SWAP(ref p1, ref p2);
            Console.WriteLine($"P1 = {p1}");
            Console.WriteLine($"P2 = {p2}");
        }
    }
}
