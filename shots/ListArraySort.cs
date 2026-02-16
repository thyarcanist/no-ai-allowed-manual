using System;
using System.Collections.Generic;
					
public class Program
{
	public static int[] arr = {45,12,10,28,5,6,3,12,50,8};
	public static int sumOfArray = 0;
	public static int a = 69;
	
	public static List<int> divOf = new List<int>();
	public static int getDiv = 5;
	public static int divCounter;
	
	public static void Main()
	{
		
		for (int o = 0; o < arr.Length; o++)
		{

			
			 // == means divisibles of 5 and != explicitly skips divisibles of 10 and 5.
			if (arr[o] % 10 != 0 && arr[o] % 5 != 0) 
			{
				sumOfArray += arr[o];
				if (sumOfArray == a)
				{
					Console.WriteLine("Nice.\n");	
				}
			}
			else if (arr[o] % getDiv == 0)
			{
				// count the number of getDiv numbers
				divCounter++;
				
				// add the numbers to the new array
				divOf.Add(arr[o]);
				
			}
			
			
		}
		
		
		Console.WriteLine($"The sum of the array is {sumOfArray} units of value.");

    // needs the string.Join method to concatenate all elements into a full parseable string 
		Console.WriteLine($"There are {divCounter} divisibles of 5 which are: {string.Join(", ", divOf)}."); 
	}
	
}
