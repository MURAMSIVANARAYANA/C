using System;
using System;
public abstract class Shape            //declare a abstract class
{
    public abstract void draw();
}
public class Rectangle : Shape       
{
    public override void draw()
    {
        int i, fact = 1,number;
       
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)            //loop start from the value 1 and multiples the value result till loop breaks.
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + number + " is: " + fact);
    
}

}
public class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing circle...");
    }

}
public class TestPolymorphism          //main method
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