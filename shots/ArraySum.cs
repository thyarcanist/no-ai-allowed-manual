using System;
					
public class Program
{
	public static int[] arr = {45,12,10,28,5};
	public static int sumOfArray = 0;
	public static int secSumOfArray = 0;
	
	public static void Main()
	{
		
		for (int i = 0; i < arr.Length; i++)
		{
			if (i == 0){
				Console.WriteLine($"The total sum before skipping will equal 100! \n");
			} else
			{
				sumOfArray += arr[i];	
			}
			
		}
		
			Console.WriteLine($"The sum of integer array is {sumOfArray} units of value.");
			Console.WriteLine($"Now let's skip mod 5s.");
		
		for (int o = 0; o < arr.Length; o++)
		{
			if (arr[o] % 5 != 0) // == means divisibles of 5 and != explicitly skips divisibles of 5.
			{
				secSumOfArray += arr[o];
			}
		}
		
		Console.WriteLine($"The sum of the array is {secSumOfArray} units of value.");
	}
}
