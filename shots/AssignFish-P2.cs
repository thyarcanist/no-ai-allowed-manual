using System;
using System.Collections.Generic;
					
public class Program
{
	public static List<Fish> fishFactory = new List<Fish>();	
	public static double basePrice = 3.25;
	public static double fishMultiplier = 1.25;
	public static int fishIndex = 5;
	
	public class Fish {
		public int ID;
		public string NAME;
		public double PRICE;
		public double WEIGHT;
	}
	
	public static void MakeFishInventory(){
		fishFactory.Add(new Fish { ID = 1, NAME = "Tilapia", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 2, NAME = "Catfish", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 3, NAME = "Cod", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 4, NAME = "Salmon", PRICE = basePrice });
		fishFactory.Add(new Fish { ID = 5, NAME = "Bluefin Tuna", PRICE = basePrice });
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

		Console.WriteLine("We have this for sale. \n");
		for (int i = 0; i < fishFactory.Count; i++) {
			// Get the fish per the ID and assign a new price based on the ID as it goes though the list.
			currentPrice = currentPrice *= fishMultiplier;
			// SetPriceByID(i, currentPrice);
			
			fishFactory[i].PRICE = currentPrice *= fishMultiplier;
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
