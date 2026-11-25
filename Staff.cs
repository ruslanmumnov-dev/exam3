public class Staff : Person
{
    private string School {get; set;}
    private double Pay;

     public  Staff (string N, string A, string S, double P) :base(N, A)
    {
      School = S;
      Pay = P;
    }  
    public string Getschool(string sch)
    {
        return sch;
    }
    public void Setschool(string sch)
    {
        System.Console.WriteLine(sch);
    }
    public double GetFee(double F)
    {
        return F;
    }
    public void Getfee(double P)
    {
       System.Console.WriteLine(P);
    }
}