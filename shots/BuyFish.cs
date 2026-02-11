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
	public static FishType[] inventory;
	
	
	
	public static void Main()
	{
		wallet = 260.75;
		// the user will 
		fishNames = new string[fishCount];
		fishPrices = new double[5];
		inventory = new FishType[0];
		AssignFish();
		
		Console.WriteLine("Wanna buy some fish? \n");
		string buyFish = Console.ReadLine();
		if (buyFish == "y" || buyFish == "Y")
		{
			Console.WriteLine($"Which type?");
		}
		else if (buyFish == "n" || buyFish == "N")
		{
			Console.WriteLine("No? Fine then.");	
		}
		
	}

	// First issue, I accidentally put the current price part in the for loop, and was wondering why it stayed the same price.
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
	
	public void PurchaseCount(int quantity, FishType fish){
		// what to do when buying?
	}
	
}
