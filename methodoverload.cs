using System;
public class Cal
{
    public static int add(int a, int b)          //method overload method checkusing different parametrs passing
    {
        return a + b;
    }
    public static int add(int a, int b, int c)
    {
        return a * b / c;
    }
    public static int add(int a)
    {
        return a;
    }
}
public class TestMemberOverloading        //main method
{
    public static void Main()
    {
        Console.WriteLine(Cal.add(12, 23));
        Console.WriteLine(Cal.add(12, 23, 25));
        Console.WriteLine(Cal.add(13));
    }
}