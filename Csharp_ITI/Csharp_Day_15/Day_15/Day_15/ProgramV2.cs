using SortingDLL;

namespace Day_15
{
    // Non Generic Delegate
    // public delegate bool condDelDt(int X);
    
    // user defined Generic Delegate
    public delegate bool condDelDt<in T>(T X);

    // Step 0 , Delegate Declaration Datatype
    // new Class (new Delegate) , Specify Function Signature 


    public class ProgramV2
    {
        #region Without Delegate

        public static List<int> FindOdd(List<int> lst)
        {
            List<int> Olst = new();
            for (int i = 0; i < lst?.Count; i++)
            {
                if (lst[i] % 2 == 1)
                    Olst.Add(lst[i]);
            }
        
            return Olst;
        }
        
        public static List<int> FindEven(List<int> lst)
        {
            List<int> Olst = new();
            for (int i = 0; i < lst?.Count; i++)
            {
                if (lst[i] % 2 == 0)
                    Olst.Add(lst[i]);
            }
        
            return Olst;
        }
        
        public static List<int> FindDivBy7(List<int> lst)
        {
            List<int> Olst = new();
            for (int i = 0; i < lst?.Count; i++)
            {
                if (lst[i] % 2 == 7)
                    Olst.Add(lst[i]);
            }
        
            return Olst;
        }

        #endregion

        #region Non Generic
        
        public static List<int> findCondition(List<int> lst, condDelDt condFunc /*Pointer to Condition Function*/)
        {
            List<int> oLst = new List<int>();
            for (int i = 0; i < oLst?.Count; i++)
            {
                if (condFunc?.Invoke(lst[i]) == true)
                    oLst.Add(lst[i]);
            }
        
            return oLst;
        }
        #endregion
        
        
        public static List<T> findCondition<T>(List<T> lst, Predicate<T> condFunc /*Pointer to Condition Function*/)
        {
            List<T> oLst = new List<T>();
            for (int i = 0; i < oLst?.Count; i++)
            {
                if (condFunc?.Invoke(lst[i]) == true)
                    oLst.Add(lst[i]);
            }
        
            return oLst;
        }
        public static void Main2()
        {

            
            List<int> iLst = Enumerable.Range(0, 100).ToList();

            List<int> iLst2 = new ();



            Predicate<int> fPtr = new Predicate<int>(conditionFunctions.chOdd);
            iLst2 = findCondition(iLst, fPtr);
            
            foreach (var item in iLst2)
                Console.Write($"{item} , ");


            List<string> nameList = new List<string>() { "Ahmed", "Aly", "Ammar" };
            Predicate<string> fPtr2 = new Predicate<string>(conditionFunctions.chLength);
            nameList = findCondition(nameList, fPtr2);
            
            foreach (var item in nameList)
                Console.WriteLine(item);

        }
    }

    class conditionFunctions
    {
        public static bool chLength(string s) => s.Length >= 4;
        public static bool chOdd(int x) => x % 2 == 1;
        public static bool chEven(int x) => x % 2 == 0;
        public static bool chDivBy7(int x) => x % 7 == 0;

    }
}

    
