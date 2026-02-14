using System;
					
public class Program
{
	public static double startTime = 10;
	
	public static void Main()
	{
		StopWatch(startTime);
	}
	
	public static void StopWatch(double time){
		for (double i = startTime - 1; i >= 0; i--)
		{	
			time--;
			Console.WriteLine($"T-Minus {time} until execute.");
		}
	}
	
	public static double StopWatchGeneric(double time){
		while (time !=0) {
		time--;
		Console.WriteLine($"T-Minus {time} until 0.");
		}
		
		return 0;
	}
}
