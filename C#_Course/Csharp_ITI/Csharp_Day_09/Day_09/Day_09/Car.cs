namespace Day_09;

public class Car : IComparable , ICloneable
{
    private int id;
    private string model;
    private int currentSpeed; 
    
    public int ID { get; set; }
    public string Model { get; set; }
    public int CurrentSpeed { get; set; }

    
    // if no user defined ctor exists , Compiler will generate Empty parameter ctor (Do Nothing)
    // public Car () {}
    // if any user defined ctor (with any signature) exists , compiler will no longer generate empty paramterless ctor 

    public Car(int _id, string _model, int _cSpeed)
    {
        id = _id;
        model = _model;
        currentSpeed = _cSpeed;
    }

    public Car(int _id , string _model) : this (_id , _model , 60)
    {
        // id = _id;
        // model = _model;
        // currentSpeed = 60;
    }

    public Car(int _id) : this (_id , "FIAT" , 60)
    {
        // id = _id;
        // model = "FIAT";
        // currentSpeed = 60;
    }
    
    
    // Copy Ctor
    public Car(Car oldC)
    {
        id = oldC.id;
        model = oldC.Model;
        currentSpeed = oldC.currentSpeed;
    }
    
    public override string ToString()
    {
        return $"{id} :: {model} :: {currentSpeed}";
    }

    public object Clone()
    {
        // two ways 
         return new Car (this); 
       // return new Car(id, model, currentSpeed);
    }

    public int CompareTo(object? obj)
    {
        Car Right = (Car)obj;
        return currentSpeed.CompareTo(Right?.currentSpeed);

    }
}