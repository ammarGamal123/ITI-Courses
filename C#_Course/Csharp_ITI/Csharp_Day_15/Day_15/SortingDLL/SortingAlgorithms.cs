namespace SortingDLL
{
    // Step 0 , Delegate Data type Declaration
    public delegate bool CompFuncDelDT(int L, int R);
    // New Delegate Datatype (class) , any object from this Delegate DT
    // Can Point to (Hold Address) Any Function with the EXACT Signature bool (int,int) 
    // Point to any Function (Static , Object) , regardless of Function name , or Access Modifier
    



    public class SortingAlgorithms
    {
        public static void BSort(int[] items)
        {
            for (int i = 0; i < items?.Length; i++)
            {
                for (int j = 0; j < items.Length - i - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        if (CompFunctions.CompGtr(items[j], items[j + 1]))
                            SWAP(ref items[j], ref items[j + 1]);

                        // (items[j], items[j + 1]) = (items[j + 1], items[j]);
                    }
                }
            }
        }

        public static void BSort( int[] items , CompFuncDelDT compFunPtr)
        {
            for (int i = 0; i < items?.Length; i++)
            {
                for (int j = 0; j < items.Length - i - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        if (compFunPtr?.Invoke(items[j] , items[j + 1]) == true)
                            SWAP(ref items[j], ref items[j + 1]);

                        // (items[j], items[j + 1]) = (items[j + 1], items[j]);
                    }
                }
            }
        }

        public static void SWAP(ref int X, ref int Y)
        {
            (X, Y) = (Y, X);
        }
    }

    public class CompFunctions
    {
        public static bool CompGtr(int L, int R) => L > R;

        public static bool CompLes(int L, int R) => L < R;



    }
}