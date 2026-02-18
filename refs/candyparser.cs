using System;
using System.Collections.Generic;

public class Program
{ // Using this as a reference to study on how to parse
    public static List<CandyItem> inventory = new List<CandyItem>();

    public class CandyItem {
        public string name;
        public int quantity;
        public double price;
        public string[] ingredients;
    }

   // fake .csv file with candy items
    public static string fakeFile = 
        "Snickers,50,1.99,chocolate|caramel|peanuts\n" +
        "KitKat,30,1.49,chocolate|wafer\n" +
        "Twix,45,1.79,chocolate|caramel|cookie\n" +
        "Skittles,100,0.99,sugar|fruit flavoring|corn syrup";


  // this is the key part to remember
    public static void ParseInventory(){
        string[] lines = fakeFile.Split('\n');

      // we are taking it string in this fake "csv" as a line, where each field is extracttede into the CandyItem class
        foreach (string line in lines){
            string[] fields = line.Split(',');
          
            CandyItem candy = new CandyItem();
            candy.name        = fields[0];
            candy.quantity    = int.Parse(fields[1]);
            candy.price       = double.Parse(fields[2]);
            candy.ingredients = fields[3].Split('|');

           // once all items are successfully extracted we add it to the array
            inventory.Add(candy);
        }
    }

    public static void Main(){
        ParseInventory();

       // this is the how each item is printed after the candyItem is parsed from the fake file to the List
        foreach (CandyItem c in inventory){
            Console.WriteLine($"{c.name} | Qty: {c.quantity} | ${c.price:F2} | Ingredients: {string.Join(", ", c.ingredients)}");
        }
    }
}
