using System;
					
public class Program
{	
		// Get Cat.
	public static string[] objects = {"dog","fish","car","monkey","rabbit","turkey","donkey", "dolphin", "iguana", "cat", "tree"};
	public static string target = "cat";
	public static int targetPosition;
	
	static void Main()
	{	
		 // Program program = new Program(); | Not necessary because everything is static.
		Console.WriteLine($"Let's find the {target}!\n");
		
		FindObject(target);
	}
	
	public static void FindObject(string target) { 
		
		for (int i = 0; i < objects.Length; i++) {
			
			if (objects[i] != target) {
				Console.WriteLine(objects[i]);	
			} else {
				SemanticPrint(objects[i]);
				targetPosition = i;
			}
		}
		
		Console.WriteLine($"\n Cat found at position: {targetPosition}");
	}
	
	public static void SemanticPrint(string tofind) {
		switch (target)
		{
			case "dog":
				Console.WriteLine("bark");
				break;
			case "cat":
				Console.WriteLine("miau");
				break;
		}
		
	}
	
}

