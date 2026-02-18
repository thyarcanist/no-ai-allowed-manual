using System;
					
public class Program
{
	public static int INIT;
	public static int COUNTFR = 50;
	public static int MULTIBY = 2;
	public static int MAX_ALLOC = 60000;
	public static bool FLAG_INIT = true;
	public static bool RESTART = false;
	public static bool HIT_MAX_ALLOC = false;
	
	public static void Main()
	{
		INIT = COUNTFR;
		CounterSO(COUNTFR);

    // while countfr is not max_alloc and the flag hasn't been hit
		while (COUNTFR != MAX_ALLOC && !HIT_MAX_ALLOC) {
			if (COUNTFR < MAX_ALLOC)
			{  // additive it until it reaches the max
				CounterRO();
			}
		}
	}

  // This is the countdown until it reaches 0
	public static void CounterSO(int count){
		for (int i = count; i >= 0; i--)
		{
			if (i == 0){
				Console.WriteLine($"COUNTFR has reached: {i}.");
				COUNTFR = 0;
				RESTART = true;
			}
		}
	}

  // this is the loop that it will hit the second if statement the second time around
	public static void CounterRO(){
		if (FLAG_INIT && RESTART) {
			COUNTFR += INIT * MULTIBY;
			Console.WriteLine($"COUNTFR is set to: {COUNTFR}.");
		}
		
		if (COUNTFR >= MAX_ALLOC){
			HIT_MAX_ALLOC = true;
		}
	}
}
