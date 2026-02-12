using System;

public class Program
{

  // Day 3 program, char parser for a given string

  public static string word = "owbwvyyeuhdownxoruentnxbsowirurnfbsyanebgjhsbevxi";

   public static void Main() {

	   char[] charValues = word.ToCharArray();
	   
		   

       // i want to check each char in the string.
     
       for (int i = 0; i < charValues.Length; i++)
       {
            Console.WriteLine($"{i} = {charValues[i]}");
       }
     
   }



}
