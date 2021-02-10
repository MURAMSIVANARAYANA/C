using System;
class Solution
{
    static void Main(string[] args)      //main method
    {
        Console.WriteLine("Enter the size:");
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        int[] a = new int[N];                         //declare a arrays one to initalizd and anotherto store the values of inatilizd values when we count the values.
        int[] c = new int[N];
        Console.WriteLine("enter the array values");
        for (int i = 0; i < N; i++)              //initailize the array.
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        N--;
        int j = 0;
        for (int i = 0; i < N; i++)                //loop for to find when two children have equal rating, they are allowed to have different number of candies
        {
            int u = a[i], v = a[i + 1];
            if (u < v)
            {
                if (u != v)
                    j++;
                c[i] = j;
            }
            else
                j = 0;
        }
        c[N] = 1;
        for (int i = N; i > 0; i--)
        {
            int u = a[i], v = a[i - 1];
            if (u <= v)
            {
                if (u == v)
                    j = 1;
                else
                    j = c[i] + 1;
                c[i - 1] = j;
            }
            else if (u > v && c[i] <= c[i - 1])
            {
                c[i] = c[i - 1] + 1;
            }
        }
        for (int i = 0; i <= N; i++)          
        {
            count += c[i];
        }
        Console.WriteLine(count);
    }
}