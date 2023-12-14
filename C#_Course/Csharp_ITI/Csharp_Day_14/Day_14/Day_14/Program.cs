using System.Collections;

namespace Day_14

{
    public class Program
    {
        // public static int SumArrayList(ArrayList lst)
        // {
        //     int Sum = 0;
        //     for (int i = 0; i < lst?.Count; i++)
        //     {
        //         if (lst.GetType() == Sum.GetType())
        //             Sum += (int)lst[i]; // UnBoxing , UnSafe
        //         else return -1;
        //     }
        //     return Sum;
        // }

        public static int SumList(List<int> iLst)
        {
            int Sum = 0;
            for (int i = 0; i < iLst?.Count; i++)
            {
                Sum += iLst[i];
            }

            return Sum;
        }
        public static void Main()
        {
            
            #region Non Generic collection
            
            ArrayList aLst = new ArrayList();
            aLst.Add(1); // Boxing 
            aLst.Add("2");
            aLst.Add(3);
            aLst.AddRange(new int[] {4 , 5 , 6});
            aLst.Remove(3);
            Console.WriteLine(aLst.Count);
            
            #endregion

            #region List
            List<int> iLst = new List<int>();
            Console.WriteLine($"Size = {iLst.Count}");
            Console.WriteLine($"Capacity = {iLst.Capacity}");
           
            iLst.Add(12);
            iLst.Add(15);
            iLst.Add(1234);
            iLst.Add(4312);
            iLst.Add(321);
            Console.WriteLine($"Size = {iLst.Count}");
            Console.WriteLine($"Capacity = {iLst.Capacity}");
           
           // iLst[10] = 20; // Argument out of range Exception 
                           // use indexer for update and Get 
            
           
            Console.WriteLine(SumList(iLst));
           
           
            List<int> a = new List<int>(new int [12]);
            #endregion

            #region Dictionary
            
            Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            // Key Must be Unique , else it will throw an exception
            PhoneBook.Add("ABC" , 123);
            PhoneBook.Add("XYZ", 456);
            PhoneBook.Add("KLM", 789);
            
            // PhoneBook.Add("XYZ", 654); // No Duplicate Keys allowed
            
            PhoneBook["XYZ"] = 876; // For Update
            PhoneBook["EFG"] = 654; // Add , For Append exactly like Add Function
            Console.WriteLine(PhoneBook["XYZ"]); // get 
            
            // Doesn't Exist
            if (PhoneBook.TryGetValue("HIJ", out long V))
                Console.WriteLine(V);
            else
                Console.WriteLine("Not Available");
            
            if (PhoneBook.ContainsKey("XYZ"))
                Console.WriteLine(PhoneBook["XYZ"]);
            else
                Console.WriteLine("Not Found");
            
            
            
            foreach (KeyValuePair<string,long> item in PhoneBook)
            {
                Console.WriteLine($"{item.Key} :: {item.Value}");
            }
            
            #endregion
            
        }
    }
}