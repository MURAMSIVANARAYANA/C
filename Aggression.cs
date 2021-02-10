using System;
public class Address
{
    public string addressLine, city, state;
    public Address(string addressLine, string city, string state)
    {
        this.addressLine = addressLine;
        this.city = city;
        this.state = state;
    }
}
public class Employee
{
    public int id;
    public string name;
    public Address address;//Employee HAS-A Address  
    public Employee(int id, string name, Address address)   //declare the fileds in the constructor.
    {
        this.id = id;
        this.name = name;
        this.address = address;

    }
    public void display()   //display  the variables from constructor.
    {
        Console.WriteLine(id);
            Console.WriteLine(name);
        Console.WriteLine(address.addressLine);
        Console.WriteLine(address.city );
        Console.WriteLine(address.state);
    }
}
public class TestAggregation
{
    public static void Main(string[] args)
    {
        Address a1 = new Address("G, Sec", "Noida", "UP");
        Employee e1 = new Employee(1, "ashmita", a1);
        e1.display();
    }
}