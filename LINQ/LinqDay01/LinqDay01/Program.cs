namespace LinqDay01
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Implicit Typed Local Variable

            // var d = 1234.4321;
            // Console.WriteLine(d.GetType());

            // d = "Hello"; // Not Valid , C# is strongly Typed Language , statically Typed Language

            #endregion

            #region Extension Method

            // int x = 12345;
            // int ans;
            //
            // // Requirement for Extension Method
            // // 1. static function
            // // 2. using this with the parameter
            // ans = x.mirror();
            //
            // Console.WriteLine(ans);
            //
            //
            //
            // List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //
            // lst.First();
            // // First function in the class called Enumerable 
            //
            // Console.WriteLine(lst.Max());

            #endregion

            // Employee e1 = new Employee()
            // {
            //     ID = 1234, Name = "Ammar", Salary = 25000
            // };
            //
            // Console.WriteLine(e1.GetType().Name);
            // Console.WriteLine(e1);
            //
            //
            // Employee e2 = new Employee() { ID = 1234, Name = "Ammar" , Salary = 25000};
            //
            // Console.WriteLine(e1.Equals(e2));


            #region Anonymous Type

            //
            // // Anonymous Data Type
            //
            // var e1 = new { ID = 1234, Name = "Ammar", Salary = 25000m };
            // Console.WriteLine(e1.GetType().Name);
            // Console.WriteLine(e1);
            // Console.WriteLine(e1.Salary);
            //
            // // e1.Name = "Samir" // Immutable Object Not Valid
            //
            //
            //
            // var e2 = new { ID = 102, Name = "Tamer", Salary = 7000m };
            // // Same DataType as long as Same Property Names (With same character Case)
            // // Same Property Type , Same Sequence 
            // Console.WriteLine(e2.GetType().Name);
            //
            // var e3 = new {ID = 105, Salary = 34233, Name = "Mido" };
            // // new Anonymous Data Type 
            // Console.WriteLine(e3.GetType().Name);
            //
            //
            // var e4 = new { ID = 1234, Name = "Ammar", Salary = 25000m };
            // if (e1.Equals(e4))
            // {
            //     Console.WriteLine("Value EQ");
            // }
            // else Console.WriteLine("Value NEQ");
            //
            // Console.WriteLine(e1.GetHashCode());
            // Console.WriteLine(e4.GetHashCode());
            // // GetHashCode based on Values not Identity
            //

            #endregion
            
            #region Ex01 Where 
            // Sequence : Class Implementing IEnumerable <T> Interface
            // Local Sequence : L2O , L2ADO , L2XML
            // Remote Sequence : L2sql , L2E
            // Sequence contains Elements

            // List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6 };
            // List<string> nameList = new List<string>()
            // {
            //     "Ahmed aly",
            //     "Sayed Samir",
            //     "Sally Salah"
            // };
            //
            // // Fluent Syntax
            //
            // // Static Function member in Enumerable Class
            // var Result = Enumerable.Where(lst, i => i % 2 == 0);
            //
            //
            // // Much more common than code the line above
            // // Extension Method
            // var R = lst.Where(i => i % 2 == 0); //.OrderByDescending(i => i);
            //
            //
            //
            // // Query Expression : Query Syntax  
            // var RR = from i in lst
            //     where i % 2 == 0
            //     // orderby i descending
            //     select i;
            
            #endregion
            
            
            #region Deffered Execution , Imidiate Execution

            // List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //
            // // Most of LINQ Operators , Deffered Execution 
            // var result = list.Where(i => i % 2 == 0);
            // Console.WriteLine(result.GetType());
            //
            //
            // list.Remove(2);
            // list.AddRange(new int[] { 10, 11, 12 });
            //
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item} , ");
            // }
            //
            // Console.WriteLine();
            //
            // list.AddRange(new int[] {14 , 15 , 16});
            //
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item} , ");
            // }
            //
            // Console.WriteLine();
            //
            //
            // // Imidiate Casting
            // // Casting , element Operators are Imidiate Execution Operators
            // // so it will not effected by the changes of the list itself
            // // it calculate the query once you define it
            // var res = list.Where(i => i % 2 == 0).ToList();
            // Console.WriteLine(list.GetType());
            //
            // foreach (var item in res)
            // {
            //     Console.WriteLine($"{item} , ");
            // }
            
            #endregion
            //git@github.com:ammarGamal123/ITI_Courses.git

        }
    }
}