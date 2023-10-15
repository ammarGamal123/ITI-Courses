namespace Model;

public class TypeB
{
    public TypeB()
    {
        TypeA O1 = new TypeA();
        O1.Z = O1.Z = 1;
        O1.L = 1;
    }
}

public class TypeC : TypeA
{
    public TypeC()
    {
        Y = Z = K = 2;
        L = 2;
        M = 2;
    }
}