using System.Collections;
using System.Diagnostics;

namespace Day_08;

public class Employee:IComparable
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

    public int CompareTo(object? obj)
    {
        // to know function CompareTo belong to ? ==> Sort
        // foreach (var item in (new StackTrace().GetFrames()))
        //     Console.WriteLine(item.GetMethod().Name);
            
            
        Employee Right = (Employee)obj;
        // if (salary > Right.salary)
        //     return 1;
        // else if (salary < Right.salary)
        //     return -1;
        // else return 0;

        return salary.CompareTo(Right.salary);
    }

    public Employee(int _id, string _name, int _salary)
    {
        ID = _id;
        Name = _name;
        salary = _salary;
    }
}