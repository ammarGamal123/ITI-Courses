using Model;
namespace Day_09
{
    class TypeD : TypeA
    {
        public TypeD()
        {
            Y = K = 4;
            L = 4;
           // this.M = 4  inaccessable  
        }
    }
    class Program
    {
        public static void Main()
        {
            #region Object Initializer
            // Employee E = new Employee();
            // E.ID = 43123;
            // E.Name = "Ammar Hammad";
            // E.Salary = 15000m;
            
            // Much More clean
            Employee E = new Employee()
            {
                ID = 101, Name = "Ammar Hammad", Salary = 10000m
             };
            
            Console.WriteLine(E.ToString());
            
            #endregion


            TypeA O3 = new();
            O3.K = 3;


            // Car C1; // Zero bytes
            // C1 = new();
            // 1. new allocate object in Heap
            // 2. new crossout (initialize) allocated object
            // 3. new Call Userdefined Ctor if exists
            // 4. new assign reference to newly allocated object

            Car C2 = new(101, "BMW", 300);

            Car C3 = new(202, "BYD");

            Console.WriteLine(C2);
            Console.WriteLine(C3);

            Console.WriteLine($"C2: {C2.GetHashCode()}");
            Console.WriteLine($"C3: {C3.GetHashCode()}");

           // C3 = C2;


           Console.WriteLine("******************************");
            
            // C3 new Object with new Identity , Same State as C2 

            // C3 = new Car(C2); // Copy Ctor 
            // Console.WriteLine("Copy Ctor");

            C3 = (Car)C2.Clone();
            Console.WriteLine("Clone");
            Console.WriteLine($"C2: {C2.GetHashCode()}");
            Console.WriteLine($"C3: {C3.GetHashCode()}");

        }
    }
}