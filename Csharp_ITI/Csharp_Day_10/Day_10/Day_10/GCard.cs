// namespace Day_10;
// // Design Pattern ==> SingleTone Design Pattern (Type)
// public class GCard
// {
//     public int Data { get; protected set; }
//
//     private GCard(int _data)
//     {
//         Data = _data;
//         Console.WriteLine("Ctor");
//     }
//     
//     
//     static GCard SingleObj;
//     // Initialized Default Value (null)
//     public static GCard GetCard()
//     {
//         
//         if (SingleObj == null)
//             SingleObj = new GCard(1234);
//
//         return SingleObj;
//     }
//     public void DoSomeGraphicWork()
//     {
//         Console.WriteLine("Processing");
//     }
//     
// }