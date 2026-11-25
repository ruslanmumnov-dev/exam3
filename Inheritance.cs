using System.ComponentModel.Design;

public class Person
{
    private string Name {get; set;} = string.Empty;
    private string Address {get; set;}= string.Empty;

    public  Person (string N, string A)
    {
        Name = N;
        Address =A;
    }
    public virtual string  GEtName(string name)
    {
        return Name; 
    }
       public virtual string  GEtAddress(string address)
    {
        return Address; 
    }
    public void SetAddress(string address)
    {
        System.Console.WriteLine(address);
    }
    // public abstract string ToString (){}
}