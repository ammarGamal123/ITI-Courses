namespace Day_10;
// Design Pattern ==> SingleTone Design Pattern (Type)
public class GCard
{
    public int Data { get; protected set; }

    private GCard(int _data)
    {
        Data = _data;
        Console.WriteLine("Ctor");
    }

    public static GCard SingleToneObj { get; } = new GCard(12345678);


    #region C# Old Version
    // static GCard SingleObj;
    // // Initialized Default Value (null)
    // public static GCard GetCard()
    // {
    //     
    //     if (SingleObj == null)
    //         SingleObj = new GCard(1234);
    //
    //     return SingleObj;
    // }
    #endregion
    
    public void DoSomeGraphicWork()
    {
        Console.WriteLine("Processing");
    }
    
}