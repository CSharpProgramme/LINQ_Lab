using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    internal class ListCollection
    {
        static void Main()
        {
            //create a new list of strings
            var items = new List<string>();

            //display list's count and capacity before adding elements
            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("red"); //append an item to the list
            items.Insert(0, "yellow"); //insert the value at index 0

            //display list's count and capacity after adding two elements
            Console.WriteLine("After adding two elements to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            //display the colors in the list
            Console.WriteLine("\nDisplay list contents with counter-controlled loop:");
            for (var i = 0; i < items.Count; i++)
            {
                Console.Write($"{items[i]} ");
            }

            //display the colors using foreach
            Console.WriteLine("\nDisplay list contents with foreach statement:");
            foreach(var item in items)
            {
                Console.Write($"{item} ");
            }

            items.Add("green"); //add "green" to the end of the list
            items.Add("yellow"); //add "yellow" to the end of the list

            //display list's count and capacity after adding two more elements
            Console.WriteLine("\n\nAfter adding two more elements to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            //display the list
            Console.Write("\nList with two new elements:");
            foreach(var item in items)
            {
                Console.Write($" {item} ");
            }

            items.Remove("yellow"); //remove the first "yellow"

            //display the list
            Console.Write("\n\nremove first instance of yellow:");
            foreach (var item in items)
            {
                Console.Write($" {item} ");
            }

            items.RemoveAt(1); //remove item at index 1

            //display the list
            Console.Write("\n\nremove second instance (green):");
            foreach (var item in items)
            {
                Console.Write($" {item} ");
            }

            //display list's count and capacity after removing two elements
            Console.WriteLine("\n\nAfter removing two elements from items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            //check if a value is in the list
            Console.WriteLine("\n\"red\" is " + $"{(items.Contains("red") ? string.Empty : "not ")}in the list");

            items.Add("orange"); //add "orange" to the end of the list
            items.Add("violet"); //add "violet" to the end of the list
            items.Add("blue"); //add "blue" to the end of the list

            //display list's count and capacity after adding three elements
            Console.WriteLine("\nAfter adding three more elements to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            //display the list
            Console.Write("list with three new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
        }
    }
}
