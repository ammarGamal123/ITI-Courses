namespace Day_04 {
    class Program
    {
        public static void Main()
        {

            #region String Formatting

            int input = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result : {input} + {input2} = {input + input2}");
            #endregion



            #region 1D Array
            // Array in C# is reference type
            // Object from Array class 
            
            // C Style
            // int Arr[5]


            int[] a;
            // Declaration for reference of int Array 
            // Zero Bytes have been allocated in Heap

            a = new int[5];

            Console.WriteLine($"Array size {a.Length} , Array Diemenstion {a.Rank}");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]} , ");
            }

            Console.WriteLine();

            int[] a2 = {7 , 8 , 9};
            Console.WriteLine($"Arr01 = {a.GetHashCode()}");
            Console.WriteLine($"Arr02 = {a2.GetHashCode()}");

            a2 = (int[]) a.Clone();
            // int [] = object;
            // Derived = Base : Not Valid Must use Explicit Casting
            // Ref to Base = Derived : Valid 
            // a2 new object with new (diff) identity but same state as a (first array)
            Console.WriteLine("After clone");
            Console.WriteLine($"Array01 {a.GetHashCode()}");
            Console.WriteLine($"Array02 {a2.GetHashCode()}");

            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine($"{a2[i]} , ");
            }

            Console.WriteLine();
            #endregion


           
    }
}