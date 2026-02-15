using System;
					
public class Program
{
	public static int[] arr = {45,12,10,28,5};
	public static int sumOfArray = 0;
	
	public static void Main()
	{
		
		for (int i = 0; i < arr.Length; i++)
		{
			sumOfArray += arr[i];	
		}
		
		Console.WriteLine($"The sum of integer array is {sumOfArray} units of value.");
	}
}
