using System;
using System.Threading;

public class MyThread
{
    public static void Thread1()         //declare a thread  to perfrom binary number convertion. 
    {
        Console.WriteLine("task one");
        int n, i;
        int[] a = new int[10];
        Console.Write("Enter the number to convert: ");
        n = int.Parse(Console.ReadLine());
        for (i = 0; n > 0; i++)               //loop to convert number to binary format
        {
            a[i] = n % 2;
            n = n / 2;
        }
        Console.WriteLine("Binary of the given number= ");
        for (i = i - 1; i >= 0; i--)
        {
            Console.Write(a[i]);
        }
    }
    public static void Thread2()
    {
        Console.WriteLine("task two");         // perfrom a febbanoic series in thread2
        int a = 0, b = 1, i, c, n, j;
        Console.Write("Enter the limit: ");
        n = int.Parse(Console.ReadLine());
        for (i = 1; i <= n; i++)           //print the values
        {
            a = 0;
            b = 1;
            Console.Write(b + "\t");
            for (j = 1; j < i; j++)           //perform the fabbonic series in the loop;
            {
                c = a + b;
                Console.Write(c + "\t");
                a = b;
                b = c;
            }
            Console.Write("\n");
        }
    }
}
public class ThreadExample
{
    public static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
        Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
        t1.Name = "Player1";
        t2.Name = "Player2";
        
        t1.Start();
        t1.Join();
        t2.Start();
        t2.Priority = ThreadPriority.Highest;
       
    }
}