using System;
public class Account
{
    public int id;
    public String name;
    public static float rateOfInterest;
    public static float intrest;
    public Account(int id, String name)   //declare a constructor 
    {
        this.id = id;
        this.name = name;
    }
    static Account()      //declare a static constructor.
    {
        rateOfInterest = 9.5f;
        intrest = rateOfInterest * 10; 
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + rateOfInterest +" " +intrest);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Account a1 = new Account(101, "Son");
        Account a2 = new Account(102, "Mahesh");
        a1.display();
        a2.display();

    }
}