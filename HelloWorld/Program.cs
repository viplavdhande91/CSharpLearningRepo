using System;
class A
{
    public virtual void Print()
    {
        Console.WriteLine("This is class A Method");
    }
}
class B : A
{
    public override sealed void Print()
    {
        Console.WriteLine("This is class B Method");
    }
}
class C : B
{
    public override void Print() //cANT OVERRRIDE BECAUSE IT IS SEALED
    {
        Console.WriteLine("This is class C Method");
    }
}
   

class Program
{

    static void Main(string[] args)
    {
        C objSealed = new C();
        objSealed.Print();
    }
}