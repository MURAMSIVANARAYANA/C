Cusing System;

// Class Declaration 
public class boy
{
 // Instance Variables 
    String name;
    String property;
    int age;
    String height;

     
    public boy(String name, String breed,int age, String color)       // Constructor Declaration of Class
    {
        this.name = name;
        this.property= property;
        this.age = age;
        this.height = height;
    }
    public String getName()   //create the property types.
    {
        return name;
    }
    public String getProperty()
    {
        return property;
    }
    public int getAge()
    {
        return age;
    }
    public String getHeight()
    {
        return height;
    }
    public String toString()  // Method to return the properties.
    {
        return ("Hi my name is " + this.getName() + ".\nMy breed, age and color are " + this.getProperty() + ", " + this.getAge() + ", " + this.getHeight());
    }
    // Main Method 
    public static void Main(String[] args)
    {
        // Creating object 
        boy tuffy = new boy("ramu", "highlet", 5, "5-10");
        Console.WriteLine(tuffy.toString());
    }
}