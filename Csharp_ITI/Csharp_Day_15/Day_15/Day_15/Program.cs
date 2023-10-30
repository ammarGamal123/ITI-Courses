using SortingDLL;

namespace Day_15
{
    
    // Step 0 , Delegate Declaration Datatype
    // new Class (new Delegate) , Specify Function Signature 
    
    public delegate int StringFunDelDT(string str);
    
    
    public class Program
    {
        
        
        public static void Main()
        {

            // C Pointer Style 
            // int X = 5;
            // 1.Pointer Declaration
            // int *Ptr;
            // 2.Pointer Initialization
            // Ptr = &x;
            // 3.Using Pointer Access Data 
            // *Ptr = 8;
            
            
            #region Delegate Ex01
            
            //  1. Delegate Declaration 
            // StringFunDelDT fPtr;
            //
            // // 2. Pointer To Function (Delegate Object) Initialzatoin
            // fPtr = new StringFunDelDT(StringFunctions.GetLength); 
            // // fPtr  ===> Static Method , Function (GetLength)
            //
            //
            // // 3. Using Pointer to Function , Call (invoke) Function
            // int R = fPtr.Invoke("ABC");
            // Console.WriteLine(R);
            //
            // fPtr = new StringFunDelDT(StringFunctions.GetUpChar);
            //
            // int L = fPtr.Invoke("ADFasdfADSF");
            // Console.WriteLine(L);
            //
            // StringFunctions S1 = new StringFunctions()
            // {
            //     Ch = 'A'
            // };
            //
            // fPtr = new StringFunDelDT(S1.GetCharNum);
            //
            // int ans = fPtr("ABCdsaA");
            // // fPtr.invoke ("ABCdsaA");
            // Console.WriteLine(ans);
            
            #endregion
            
            
            #region Delegate Ex02
            
            int[] Arr = { 3, 1, 5, -2 , -4 , 4, 2, 8, 7, 6 };
            
            // SortingAlgorithms.BSort(Arr);
            
            // foreach (var i in Arr)
            // {
            //     Console.WriteLine(i);   
            // }
            
            CompFuncDelDT fPtr2 = (CompFunctions.CompLes);
            fPtr2 = CompFunctions.CompLes;
            // Implicit Casting from Function to Pointer
            
            // fPtr2 = CompFunV2.CompAbsGrt;
            //SortingAlgorithms.BSort(Arr , fPtr2);
            
            SortingAlgorithms.BSort(Arr , CompFunV2.CompAbsGrt);
            
            
            foreach (var item in Arr) Console.Write ($"{item} ");
            #endregion


            List<int> iLst = Enumerable.Range(0, 100).ToList();

            List<int> iLst2 = new ();

            
            
            foreach(var item in iLst2)
                Console.Write($"{item} , ");

        }
    }

    public class CompFunV2
    {
        public static bool CompAbsGrt(int x, int y) => Math.Abs(x) > Math.Abs(y);
    }
    public class StringFunctions
    {
        public static int GetLength(string str)
        {
            return str?.Length ?? -1;
        }
        
        public char Ch { get; set; }
        public int GetCharNum(string str)
        {
            int counter = 0;
            for (int i = 0; i < str?.Length; i++)
            {
                if (str[i] == Ch) counter++;
            }

            return counter;
        }

        public int GetFullName(string fName, string lName)  
        {
            return (int)(fName?.Length + lName?.Length)!;
        }

        public static int GetUpChar(string str)
        {
            int counter = 0;
            for (int i = 0; i < str?.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    counter++;
            }

            return counter;
        }
    }
}
