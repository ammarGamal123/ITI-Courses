using Common;
namespace Day_06;

public class class2
{
    static void Main()
    {
        // Point p;
        // // Allocate 8 UnInitialized bytes in Stack  
        // Console.WriteLine(p1);

        Point p2 = new Point(10, 15);
        // p2 allocated in Stack
        // use new just for Ctor selection 
        Console.WriteLine(p2.ToString());

        Point p3 = new Point(20);

        Console.WriteLine(p3);


        Point p4 = new Point();

        Console.WriteLine(p4);
    }
}