using System;
					
public class Program
{
	public static double startTime = 30;
	
	public static void Main()
	{
		StopWatch(startTime);
	}
	
	public static void StopWatch(double time){
		for (double i = time; i > 0; i--)
		{	
			Console.WriteLine($"T-Minus {i} until execute.");
			// FizzBuzz must go first
			if (i % 3 == 0 && i % 5 == 0){
				Console.WriteLine("FIZZBUZZ.");	
			} else if (i % 3 == 0) {
				Console.WriteLine("MOD 3 = FIZZ.");	
			} else if (i % 5 == 0) {
				Console.WriteLine("MOD 5 = BUZZ.");	
			}
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
