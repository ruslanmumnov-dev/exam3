 public class Student : Person
{
       private string Program{ get; set;}
       private int Year ;
       private double Fee;

       public  Student (string N, string A, string P, int Y, double F) :base(N, A)
    {
        Program = P;
        Year = Y;
        Fee = F;
    }  
    public string GetProgram(string n)
    {
        return  n;
    }
    public void SetProgram(string n)
    {
        Program = n;
    }
    public int  GetYear(int n)
    {
        return n;
    }
    public void SetYeat(int n)
    {
        Year =n;
    }public double  Getfee(double n)
    {
        return n;
    }
    public void Setfee(double n)
    {
        Fee = n;
    }
}