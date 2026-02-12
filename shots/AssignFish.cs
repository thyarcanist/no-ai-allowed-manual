using System;
					
public class Program
{
	public enum FishType {
		Tilapia, // cheapest
		Catfish,
		Cod,
		Salmon,
		BluefinTuna // most expensive
	}
	
	public static int fishCount = Enum.GetValues(typeof(FishType)).Length;
    public static string[] fishNames;
	
	public static double basePrice = 7.25f;
	public static double fishMultiplier = 1.25;
	
	public static double[] fishPrices;
	
	// user
	public static double wallet;
	
	
	
	public static void Main()
	{
		wallet = 260.75;
		// the user will buy a fish? - removing this for now, that will be a different script
		fishNames = new string[fishCount];
		fishPrices = new double[5];
		inventory = new FishType[0];
		AssignFish();
		
		Console.WriteLine("Wanna browse some fish? \n");
		string browseFish = Console.ReadLine();
		if (browseFish == "y" || browseFish == "Y")
		{
			Console.WriteLine($"Which type?");
		}
		else if (browseFish == "n" || browseFish == "N")
		{
			Console.WriteLine("No? Fine then.");	
		}
		
	}

	// First issue, I accidentally put the current price part in the for loop, and was wondering why it stayed the same price. | solved.
	public static void AssignFish(){
		double currentPrice = basePrice;
		
		Console.WriteLine("Here's the list of fish we've got for sale. \n");
		for (int i = 0; i < fishCount; i++) {
			fishNames[i] = Enum.GetValues(typeof(FishType)).GetValue(i).ToString();	
			fishPrices[i] = currentPrice *= fishMultiplier;
			Console.WriteLine($"{fishNames[i]} is ${fishPrices[i]:F2}.");
		}
		Console.WriteLine("\n");
	}
	
}
