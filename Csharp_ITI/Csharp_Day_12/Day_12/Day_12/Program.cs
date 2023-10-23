namespace Day_12
{
    class Program
    {
        public static void Main()
        {
            #region Virtual
            
            TypeA baseRef = new TypeA(1);
            baseRef.staticallyBindedShow(); // Base 
            baseRef.DynShow(); // Base
            
            TypeB derivedRef = new TypeB(2 , 3);
            derivedRef.staticallyBindedShow(); // Derived
            derivedRef.DynShow(); // Derived
            
            
            
            baseRef = new TypeB(4, 5);
            // Ref to Base = Derived Object
            // baseRef.A = 6;
            baseRef.staticallyBindedShow(); // Base
            // Statically Binded methods (non Virtual) Compiler Bind based ..
            // in Reference Type not Object Type
            
            baseRef.DynShow(); // Derived
            // Dynamically Binded Method , CLR will bind Function Call based on ... 
            // Object Type in Runtime 
            
            baseRef = new TypeC(7 , 8 , 9);
            
            derivedRef = new TypeC(10 , 11 , 12);
            
            baseRef.DynShow(); // TypeC
            
            derivedRef.DynShow(); // TypeC
            
            
            baseRef = new TypeD();
            baseRef.DynShow(); // TypeC
            
            
            TypeD derivedD = new TypeD();
            derivedD.DynShow(); // TypeD
            
            
            #endregion

            
            
            
        }
    }
}