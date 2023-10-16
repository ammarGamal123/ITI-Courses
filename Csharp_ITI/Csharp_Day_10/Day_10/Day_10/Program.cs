namespace Day_10
{
    class Program
    {
        public static void Main()
        {
            
            #region Static Ctor , Static Class
            // Console.WriteLine(Utility.Cm2Inch(254));
            // Console.WriteLine(Utility.CircleArea(10));
            //
            // // Utility U1 = new Utility(10 , 20);
            // // Utility U2 = new Utility(30, 40);
            //
            // // Can't Access Static Funs with Objects 
            // Console.WriteLine(Utility.Cm2Inch(13));
            // Console.WriteLine(Utility.Inch2Cm(10));
            #endregion
            
            #region  SingleTone 
            // GCard card01 = GCard.SingleToneObj;
            // GCard card02 = GCard.SingleToneObj;
            //
            // Console.WriteLine($"card01 {card01.GetHashCode()}");
            // Console.WriteLine($"card02 {card02.GetHashCode()}");
            #endregion


            Complex C1 = new Complex()
            {
                Real = 10, Imag = 15
            };
            Complex C2 = new Complex()
            {
                Real = 20, Imag = 25
            };

            Complex C3 = default, C4 = default;
            


            // C3 = C1 + C2;
            // C4 = C1 + 7;
        
            // C1 += C2; // Automatically Generated Cause you Generate (+) 
            //
            // C2 = -C3; // Unary arithmatic operator

            C3 = ++C1;
            C4 = C2++;


            int R = (C1); // Implicit Casting
            string str = (string)C2; // Explicit Casting

            // str = C3; // Must be Explicit
            
            
            Console.WriteLine(C1);
            Console.WriteLine(C2);
            Console.WriteLine(C3?.ToString());
            Console.WriteLine(C4?.ToString());


            Employee E = new Employee()
            {
                ID = 1234 , Name = "Ammar Hammad" , Salary = 15000
            };

            Person P = (Person)E;

            Console.WriteLine(P.ToString());

        }
    }
}