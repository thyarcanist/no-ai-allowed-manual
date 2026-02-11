using System;
					
public class Program
{
	public static bool _isLinear = true;
	public static float _selectedRate = .24f;
	public static float currentRate = 0f;
	public static float limitOfRate = 7.25f;
	public static float baseRateChange = 1.25f;
	public static int totalCountOfChanges = 0;
	
	public static void Main()
	{
		Console.WriteLine("Choose a growth style, and rate.");
		SelectYourGrowth(_isLinear, _selectedRate);
	}
	
	
	public static void SelectYourGrowth(bool isLinear, float selectedRate) {
		bool choosing = true;
		Console.WriteLine("Enter L for linear or E for exponential: \n");
		string choice = Console.ReadLine();
		while (choosing == true) {
			if (choice == "L"){
				_isLinear = true;
				choosing = false;
			}
			else if (choice == "E") {
				_isLinear = false;
				choosing = false;
			}
		}
		
			if (_isLinear) {
				RateOfLinearChange(selectedRate);
			} else {
				RateOfExponentialChange(selectedRate);	
			}
	}
	
		// This is a linear growth rate
	public static void RateOfLinearChange(float rate){	
		currentRate = rate;
		while (currentRate < limitOfRate) {
			currentRate += rate * baseRateChange;
			totalCountOfChanges++;
			Console.WriteLine($"Rate is: {currentRate}");
			if (currentRate >= limitOfRate) {
				Console.WriteLine($"Rate is has been met. It took {totalCountOfChanges} iters of change to reach this point.");
				totalCountOfChanges = 0;
				break;	
			}
		}
	}
	
		// This is a exponential growth rate
	public static void RateOfExponentialChange(float rate){	
		currentRate = rate;
		while (currentRate < limitOfRate) {
			currentRate *= baseRateChange;
			totalCountOfChanges++;
			Console.WriteLine($"Rate is: {currentRate}");
			if (currentRate >= limitOfRate) {
				Console.WriteLine($"Rate is has been met. It took {totalCountOfChanges} iters of change to reach this point.");
				totalCountOfChanges = 0;
				break;	
			}
		}
	}
}
