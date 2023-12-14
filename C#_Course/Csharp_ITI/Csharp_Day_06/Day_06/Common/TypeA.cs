namespace Common
{
  // Default Access Modifier inside Namespace : internal 
  // internal vs  public 
    public struct TypeA
    {
        private int X = 123;
        // Default Access Level : Private

        internal int Y;
        // Accessable inside Assembly file , inside the same Project

        public int Z;
        
        public void Print()
        {
            Console.WriteLine($"X = {X} , Y = {Y} , Z = {Z}");
        }

        public TypeA()
        {
            
        }
    }
}