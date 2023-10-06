namespace Day_08;

public class Class1
{
    public static void Main()
    {
        // try
        // {
        //     DoSomeWork();
        // }
        // catch (Exception Ex)
        // {
        //     Console.WriteLine(Ex.Message);
        //     Console.WriteLine("Main Catch");
        // }
        try
        {
            DoSomeProtectiveWork();
        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.Message);
            Console.WriteLine("General Main Catch");
        }
    }

    public static void DoSomeProtectiveWork()
    {
        int X, Y, Z;
        
        // Try Parse return false , if string can't be parse to int , No Exception will be fired
        do
        {
            Console.WriteLine("Enter First Number");
        } while (!int.TryParse(Console.ReadLine() , out X));

        do
        {
            Console.WriteLine("Enter Second Number");
        } while (!int.TryParse(Console.ReadLine(), out Y) || (Y <= 0));


        Z = X / Y;

        int[] Arr = { 3, 4, 5 };

        if (Arr?.Length > 3)
        {
            Arr[3] = 8;
        }

    }
    
    
    
    public static void DoSomeWork()
    {
        int X, Y, Z;
        try
        {
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            Z = X / Y;
            if (Y < 0)
                throw new NegativeNumberException();


            int[] Arr = { 1, 2, 3 };
            Arr[3] = 4;

            Console.WriteLine(Z);
        }
        catch (NegativeNumberException Ex)
        {
            Console.WriteLine(Ex.Message);
        }
        catch (DivideByZeroException Ex)
        {
            Console.WriteLine("Y Can't Equal Zero");
        }
        catch (ArithmeticException Ex)
        {

        }
        catch (FormatException Ex)
        {
            Console.WriteLine("Check string Format");
        }
        // catch (Exception Ex)
        // {
        //     Console.WriteLine(Ex.Message);
        // }
        finally
        {
            Console.WriteLine("Inside Finally");
        }
        Console.WriteLine(@"Code After Try \ Catch");

    }
}