using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Programs");
            Console.WriteLine("..........................");
            Console.WriteLine("List Collection List<T>");
            var state = new List<string>(); // declare the variables for generic class List<>.
            state.Add("label");
            state.Add("size");
            state.Add("strom");
            foreach (var num in state)  // loop will run each word contains in the list.
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("...................................");


            var state2 = new List<string> { "label", "sizeof", "strom", "karma", "sulthan" };  //declare variables while decleration of list.
            state.Remove("sulthan");
            for (var index = 0; index < state2.Count; index++)
            {
                Console.WriteLine(state2[index]);
            }
            Console.WriteLine(".....................................");
            Console.WriteLine("sort the list values ");
            var numbers = new List<int> { 0, 2, 4, 22, 5, 33, 78, 90, 1, 32 };
            numbers.Sort(); // sort the list using Sort() method 
            for (int num = numbers.Count - 1; num >= 0; num--)
            {
                if (numbers[num] % 2 == 0)
                    Console.WriteLine(numbers[num]);
            }
            Console.WriteLine("..........................................");

            Console.WriteLine("C# SortedSet<T> example");
            SortedList val = new SortedList();  //sort the values once we declare all the words once we declared in sorted order.
            val.Add("maths", 87);
            val.Add("scince", 99);
            val.Add("data structures", 100);
            for (int i = 0; i < val.Count; i++)
            {
                Console.WriteLine("{0}:\t{1}", val.GetKey(i), val.GetByIndex(i));
            }

            Console.WriteLine("...............................................");
            Console.WriteLine("C# Hashtable<T> example");

            Hashtable mytab = new Hashtable();    //// Adding key/value in the hashtable using Add() method 

            mytab.Add("sunday", 0);
            mytab.Add("monday", 1);
            mytab.Add("tuesday", 2);
            mytab.Add("wednesday", 3);
            foreach (DictionaryEntry ele1 in mytab)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            if (mytab.ContainsKey(6))
                Console.WriteLine("contains variable in table");
            else Console.WriteLine("doesnot contain variable in table");

            Console.WriteLine("..............................................");
            Console.WriteLine("C# Stack<T> example");
            Stack values = new Stack();     // Add values in stack using push operation. 
            values.Push(54);
            values.Push(1);
            values.Push(23);
            values.Push(2);
            values.Push(12);
            values.Push(87);
            
            foreach (var vale in values)
            {
               
                Console.WriteLine(vale);

            }
            if(values.Contains(23))
            {
                values.Pop();
            }
            foreach (var vale in values)
            {
                Console.WriteLine(vale);
            }
            Console.WriteLine("..............................");
            Console.WriteLine("C# LinkedList<T> example");
            var names = new LinkedList<string>();
            names.AddLast("ravi");
            names.AddLast("Vinusha");
            names.AddLast("mahit");
            names.AddLast("priya");

            
            LinkedListNode<String> node = names.Find("mahit"); //Insert the nme before mahit.

            names.AddBefore(node, "jyshoni");
            names.AddAfter(node, "meghana");
 
            foreach (var name in names)                     // Iterate list element using foreach loop 
            {
                Console.WriteLine(name);
            }
        }
    }
}
