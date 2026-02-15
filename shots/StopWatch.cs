using System;
					
public class Program
{
	public static double startTime = 30;
	public static int modA = 3;
	public static int modB = 5;
	
	public static void Main()
	{
		StopWatch(startTime);
	}
	
	public static void StopWatch(double time){
		for (double i = time; i > 0; i--)
		{	
			Console.WriteLine($"T-Minus {i} until execute.");
			// FizzBuzz must go first
			if (i % modA == 0 && i % modB == 0){
				Console.WriteLine($"FIZZBUZZ.");	
			} else if (i % modA == 0) {
				Console.WriteLine($"MOD {modA} = FIZZ.");	
			} else if (i % modB == 0) {
				Console.WriteLine($"MOD {modB} = BUZZ.");	
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
