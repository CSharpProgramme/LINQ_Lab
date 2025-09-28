using System;

public class LINQWithArrayOfObjects
{
	static void Main()
	{
        var employees = new[]
           {
                new Employee {"Jason", "Red", 5000M},
                new Employee {"Ashley", "Green", 7600M},
                new Employee {"Matthew", "Indigo", 3587.5M},


            };

        Console.WriteLine("Original array:");
        foreach (var element in employees)
        {
            Console.WriteLine(element);
        }
    }
}
