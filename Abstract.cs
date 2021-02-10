using System;
public abstract class Shape           //declare  a abstract method
{
    public abstract void draw();
}
public class Rectangle : Shape         //Invoke the method in abstrat class
{
    public override void draw()
    {
        int n, r, sum = 0, temp;
        
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)               //run the loop till the condition returns false
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        if (temp == sum)
            Console.WriteLine("Armstrong Number.");
        else
            Console.WriteLine("Not Armstrong Number.");
    }
}
public class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing circle...");
    }
}
public class TestAbstract
{
    public static void Main()
    {
        Shape s;
        s = new Rectangle();
        s.draw();
        s = new Circle();
        s.draw();
    }
}