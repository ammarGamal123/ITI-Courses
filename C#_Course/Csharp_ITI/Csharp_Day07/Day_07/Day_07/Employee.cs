namespace Day_07;

    struct Employee
{
    public int ID;
    private string Name;
    private decimal salary; 
    public string GetName()
    {
        return Name;
    }

    internal void SetName(string name)
    {
        Name = name.Length <= 20 ? name : name.Substring(0, 20);
    }
    
    // Property ====> Function  
    public decimal Salary
    {
        get { return salary;}
        internal set { salary = value; }
    }

    public decimal Deduction
    {
        get { return 0.11m * salary; }
    }
    
    
    public override string ToString()
    {
        return $"{ID}::{Name}::{salary}";
    }
    
    
    
    
}