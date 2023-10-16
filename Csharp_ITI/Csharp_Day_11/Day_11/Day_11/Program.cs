namespace Day_11;
class Program
    {
        public static void Main()
        {
            Point p1 = new()
            {
                X = 1 , Y = 2
            };
            Point p2 = new()
            {
                X = 1 , Y = 2
            };
            Point p3 = p1;

            // p2 = default;
            
            if (p1.Equals(p2))
                Console.WriteLine("p1 EQ p2");
            else 
                Console.WriteLine("p1 NEQ p2");
            if (p1.Equals(p3))
                Console.WriteLine("p1 EQ p3");
            else 
                Console.WriteLine("p1 NEQ p3");

            Point3D P3D = new Point3D()
            {
                X = 1 , Y = 2 , Z = 143
            };


            if (p1.Equals(P3D))
                Console.WriteLine("P1 EQ P3D");
            else
                Console.WriteLine("P1 NEQ P3D");
        }
    }
