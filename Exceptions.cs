using System;
public class InvalidAgeException : Exception
{
    public InvalidAgeException(String message)
        : base(message)
    {

    }
}
public class TestUserDefinedException              //Exception program to validate the age that required to vote.
{
    static void validate(int age)

    {
        if (age < 18)   // if the age is less than 18 then tro an exception that age must be greater.
        {
            throw new InvalidAgeException("Sorry, Age must be greater than 18");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            validate(19);
        }
        catch (InvalidAgeException e) { Console.WriteLine(e); }       //catch the exception.
        Console.WriteLine("Rest of the code");
    }
}