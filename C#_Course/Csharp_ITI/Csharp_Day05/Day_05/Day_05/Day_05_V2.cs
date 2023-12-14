using System.Diagnostics;
using System.Threading.Channels;

namespace Day_05
{
   class Class1
   {
      // public static void funTwo()   
      // {
      //    // int X = 0;
      //    // int Y = 7 / X;
      //    StackTrace sTrace = new StackTrace();
      //    StackFrame[] sFrames = sTrace.GetFrames();
      //
      //    for (int i = 0; i < sFrames.Length; i++)
      //    {
      //       Console.WriteLine(sFrames[i].GetMethod()?.Name);
      //    }
      // }
      public static void funOne()
      {
         // funTwo();
      }

      public static void SWAP(ref int X,ref  int Y)
      {
         X = Y * X;
         Y = X / Y;
         X = X / Y;
      }
      public static void PrintLine()
      {
         funOne();
         int i = 0;
         for (; i < 5; i++)
            Console.Write("#");
         Console.WriteLine();

      }


      public static void Main()
      {
         int A = 21, B = 11;
         
         SWAP(ref A , ref B);

         Console.WriteLine($"A = {A}");
         Console.WriteLine($"B = {B}");

      }
   }
}