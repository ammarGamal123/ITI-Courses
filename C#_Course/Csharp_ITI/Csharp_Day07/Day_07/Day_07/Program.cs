namespace Day_07
{
    // The Importance for enum is for readability and less confused with the code
    // enum ===> variable integer
    enum Grades
    {
        A , B , C , D , E , F
    }
    
    
    // 
    enum Branches:byte
    {
        SV = 105 , NasrCity = 201 , Alex = 221 , Assiut , Ismailia , Mansoura
    }

    
    [Flags]
    enum Permissions:byte
    {
        Read = 0x08 , Write = 4 , Execute = 0b_0000_0010 , Delete = 0x01 , RootUser = 0x0f
    }
    class Program
    {
        public static void Main()
        {
            #region Enum Ex01
            
            Grades MyG = Grades.A;
            
            MyG = Grades.F;
            
            if (MyG == Grades.F)
                Console.WriteLine(":(");
            
            Console.WriteLine(MyG);
            
            
            MyG = (Grades)3;
            
            Console.WriteLine(MyG);
            
            #endregion
            
            #region Enum Ex02
            
            Branches myBranches = new Branches();
            
            myBranches = Branches.Ismailia;
            
            Console.WriteLine(myBranches);
            
            
            #endregion
            
            #region Enum Ex03
            
            Permissions myPerm = Permissions.Read;
            
            Console.WriteLine(myPerm);
            
            myPerm ^= Permissions.Write;
            
            if ((myPerm & Permissions.Read) == Permissions.Read)
                Console.WriteLine("Contains Read");
            else Console.WriteLine("Doesn't Contain Read");
            
            Console.WriteLine(myPerm);
            
            myPerm ^= Permissions.Read;
            
            
            if ((myPerm & Permissions.Read) == Permissions.Read)
                Console.WriteLine("Contains Read");
            else Console.WriteLine("Doesn't Contain Read");
            
            Console.WriteLine(myPerm);
            
            #endregion
            
            
            #region Property
            Employee e = new();
          
            e.ID = 12;
            Console.WriteLine(e.ID);
            
            e.SetName("Ammar Gamal");
            Console.WriteLine(e.GetName());
          
            e.Salary = 1000m; // Set 
            Console.WriteLine(e.Salary); // Get 
          
          //  e.Deduction = 123; Not Valid Deduction doesn't has setter 
            Console.WriteLine(e.Deduction);
            
            #endregion


            PhoneBook book = new(5);
            
            book.SetEntry(0 , "ABC" , 123);
            book.SetEntry(1 , "XYZ" , 456);
            book.SetEntry(2 , "KLM" , 789);


            Console.WriteLine(book.GetNumber("KLM"));

            // indexer
            book["XYZ"] = 654;
            Console.WriteLine(book["XYZ"]);

            for (int i = 0; i < book.Size; i++)
            {
                Console.WriteLine(book[i]);
            }

            book[4, "DEF"] = 543;
            Console.WriteLine($"{book[4]} ::: {book["DEF"]} ");


        }
    }
}