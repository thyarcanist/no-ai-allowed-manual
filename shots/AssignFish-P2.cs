using System;
using System.Collections.Generic;
					
public class Program
{
	public static List<Fish> fishFactory = new List<Fish>();	
	public static double basePrice = 3.25;
	public static double fishMultiplier = 1.07;
	public static int fishIndex = 15;
	
	public class Fish {
		public int ID;
		public string NAME;
		public double PRICE;
		public double WEIGHT;
	}
	
	public static void MakeFishInventory(){
		
		// this is actually supposed to be in compounding order
		// this is actually supposed to be in compounding order
		fishFactory.Add(new Fish { ID = 1, NAME = "Tilapia", PRICE = basePrice }); // Cheapest
		fishFactory.Add(new Fish { ID = 2, NAME = "Catfish", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 3, NAME = "Pollock", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 4, NAME = "Cod", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 5, NAME = "Haddock", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 6, NAME = "Trout", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 7, NAME = "Mackerel", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 8, NAME = "Snapper", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 9, NAME = "Sea Bass", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 10, NAME = "Halibut", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 11, NAME = "Salmon", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 12, NAME = "Swordfish", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 13, NAME = "Yellowtail", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 14, NAME = "Ahi Tuna", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 15, NAME = "Bluefin Tuna", PRICE = basePrice }); // Most Expensive
	}
	
	// Get the Fish by the itemID
	public static string GetFishByID(int id){
		return fishFactory.Find(fishFactory => fishFactory.ID == id).NAME;
	}
	
	// Get the Fish by the ID
	public static double GetFishPriceByID(int id){
		return fishFactory.Find(fishFactory => fishFactory.ID == id).PRICE;
	}
	
	// Set the Price of the Fish by the ID --- UNUSED
	public static double SetPriceByID(int id, double newPrice){
		return fishFactory.Find(fishFactory => fishFactory.ID == id).PRICE = newPrice;
	}
	
	// This should set the price of the fish akin to the same somewhat pattern as the AssignFish script
	public static void SetFishPricesCompounding(){
		double currentPrice = basePrice;
		double totalPrice;
		
		Random random = new Random();
		double minValue = 1;
		double maxValue = 100;
		double randomNumber = random.Next((int)minValue, (int)maxValue);

		Console.WriteLine("We have this for sale. \n");
		for (int i = 0; i < fishFactory.Count; i++) {
			// Get the fish per the ID and assign a new price based on the ID as it goes though the list.
			currentPrice = currentPrice *= fishMultiplier;
			// SetPriceByID(i, currentPrice);

			//randomize the weight of the fish
			fishFactory[i].WEIGHT = randomNumber;

			// calculate the total price based on the weight
			totalPrice = fishFactory[i].PRICE * fishFactory[i].WEIGHT;

			// assign the fish the new price based on weight.
			fishFactory[i].PRICE = totalPrice *= fishMultiplier;
		}
		Console.WriteLine("\n");
	}
	
	public static void Main()
	{
		MakeFishInventory();
		SetFishPricesCompounding();
		Console.WriteLine($"{GetFishByID(fishIndex)} is ${GetFishPriceByID(fishIndex):F2}.");
	}
}
