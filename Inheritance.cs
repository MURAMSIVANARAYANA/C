using System;
public class Animal     //declare a class name
{
    public void eat() {
        Console.WriteLine("Eating...");
        Console.WriteLine("Fighting..");
    }
}
public class Dog : Animal   //Inherit the properties ofanimal properties into dog class
{
    public void bark() {
        Console.WriteLine("Barking...");
        Console.WriteLine("flirting..");
    }
}
public class BabyDog : Dog   //inherit the properties of dog in the child class babydog.
{
    public void weep() {
        Console.WriteLine("Weeping...");
        Console.WriteLine("standing");
    }
}
class TestInheritance2          //Main class
{
    public static void Main(string[] args)
    {
        BabyDog d1 = new BabyDog();
        d1.eat();
        d1.bark();
        d1.weep();
    }
}