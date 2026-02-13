using System;
using System.Collections.Generic;
					
public class Program
{

  	// wrong pattern - useful for lookups only public static Dictionary<string,double> storeMenu = new Dictionary<string,double>();
	public static List<MenuItem> storeMenu = new List<MenuItem>();	// make a list of that new class of item

  // needed to make a class because dictionaries and a normal list what's correct.
	public class MenuItem {
		public int ID;
		public string NAME;
		public double PRICE;
	}
	
		public static void InitializeStoreMenu() {
		
		storeMenu.Add(new MenuItem { ID = 1, NAME = "Spring Rolls", PRICE = 4.75 });
		storeMenu.Add(new MenuItem { ID = 2, NAME = "Double Cheeseburger", PRICE = 5.25 });
		storeMenu.Add(new MenuItem { ID = 3, NAME = "Beef Shishkabob", PRICE = 8.25 });
    	storeMenu.Add(new MenuItem { ID = 4, NAME = "California Roll", PRICE = 16.25 });
	}

  // Had to write a method to fetch the MenuItem by the ID and return it.
	public static string GetMenuItemByID(int id){
		return storeMenu.Find(MenuItem => MenuItem.ID == id).NAME;
	}
	
	public static double GetPriceByID(int id){
		return storeMenu.Find(MenuItem => MenuItem.ID == id).PRICE;
	}
	
	public static void Main() {
	
		InitializeStoreMenu();

    // It should print the beef shishkabob
		Console.WriteLine($"Item number 3 is {GetMenuItemByID(3)} which is {GetPriceByID(3)}.");

	}
	

}
