// namespace LinqDay01;
//
// public class Employee
// {
//     public int ID { get; internal set; }
//     public string Name { get; internal set; }
//     public decimal Salary { get; internal set; }
//
//
//     public override bool Equals(object? obj)
//     {
//         if (obj is Employee R)
//         {
//             if (this.GetType() != R.GetType()) return false;
//             if (Object.ReferenceEquals(this, R)) return false;
//
//             return ID == R.ID && Name == R.Name && Salary == R.Salary;
//         }
//
//         return false;
//     } 
//
//     public override string ToString()
//         => $"ID = {ID} , Name = {Name} , Salary = {Salary}";
//
//     public override int GetHashCode()
//     {
//         return base.GetHashCode();
//     }
// }