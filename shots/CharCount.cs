using System;

public class Program
{

  // Day 3 program, char parser for a given string
  // Ha! now I know how to evaluate how many characters are in a text box's string

  public static string word = "owbwvyyeuhdownxoruentnxbsowirurnfbsyanebgjhsbevxi";
  public static char[] charValues = word.ToCharArray();

   public static void Main() {
		
	   int wCount = 0;
	   int rCount = 0;
	   int otherChars = 0;
	   int totalCharCount = word.Length;
	   
       // EACH CHAR in STRING without using ToCharArray();	   
	   foreach (char o in word){
			// Console.WriteLine($"{o}");
		   if (o == 'w'){
				wCount++;   
		   } else if (o == 'r') {
		   		rCount++;
		   } else {
				otherChars++;   
		   }
	   }
	   
	   Console.WriteLine($"There are: {wCount} of 'w'.\n There are: {rCount} of 'r'.\n Every other character is {otherChars} in count.\n ");
	   Console.WriteLine($"There are {totalCharCount} of char's total.");
     
   }
	   
	   // i want to check each char in the string; solved. but not for a more manual approach?
	   // initial bug for this that was solved, needed to but >= 0 because it needs to reach the end of the string.
	   // holding these patterns for use later
	   public static void EndToFront() {
		for (int i = charValues.Length - 1; i >= 0; i--){
			Console.WriteLine($"{i} = {charValues[i]}");
		}
	   }
	   
	   public static void FrontToEnd(){
		for (int i = 0; i < charValues.Length; i++) {
        	Console.WriteLine($"{i} = {charValues[i]}");
       	}
	   }
     
   }
	
