namespace Day_08
{
    class Program
    {
        // Dev01
        public static void ProcessSeries(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current} , ");
                series.GetNext(); 
            }

            Console.WriteLine();
            series.Reset();
        }
        public static void MainV1()
        {
            #region Interface
            
            // SeriesByTwo series01 = new();
            // ProcessSeries(series01);
            //
            //
            // ISeries series02; 
            // // Valid , Reference to any Class/Struct Implementing ISeries Interface
            //
            // // series01 = new ISeries(); Not Valid
            //
            // series02 = new FibSeries();
            // ProcessSeries(series02);
            
            #endregion


            int[] Arr = { 5, 7, 1, 9, 2, 3, 1, 143 };

            Array.Sort(Arr);
            
            
            foreach(int i in Arr) // i : foreach Iteration Variable : Arr[i] , less in performance
                Console.WriteLine(i); // i : readonly    

            Employee[] EArr = new Employee[3]
            {
                new Employee(5, "Ammar Gamal", 50000),
                new Employee(8, "Sayed Ali", 12300),
                new Employee(2, "Mona Aly", 10000)
            };

            Array.Sort(EArr);

            foreach (Employee item in EArr)
                Console.WriteLine(item);
        }
    }
}