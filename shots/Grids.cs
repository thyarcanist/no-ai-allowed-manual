using System;
using System.Collections.Generic;
					
public class Program
{
	public static int[,] GRID;
	public static List<int> arrayY; //accidentally made this into an list of type int's each int index was its own array of List<int[]>
	public static int totalArraySize = 36;
	public static int gridSize = 6;
	public static int gridSizeCells = gridSize * gridSize;
	public static int row = gridSize;
 	public static int col = gridSize;
	
	public static void Main()
	{	
		PopulateArray();
		PopulateGrid();
	}
	
	public static void PopulateArray(){
		arrayY = new List<int>();
		
		for (int i = 0; i < totalArraySize; i++){
			// adding <= 1 (adds a +1)
			arrayY.Add(i);
		}
		
		Console.WriteLine($"This is a 1D integer array of: {arrayY[3].ToString()} of {arrayY.Count}.\n");
	}
	
	// Moving from Linear to [,] is harder than previously thought
	// Sometimes for especially dynamic games the Grid COULD be a resizable list.
	public static void PopulateGrid(){
		// 6x6 Grid? - perhaps later?
		int row = gridSize;
		int col = gridSize;
		
		GRID = new int[row,col]; // makes an empty grid of 36 cells of "0"
		
		// populate the grid
		for (int i = 0; i < gridSizeCells; i++)
		{	
			// this is just reinitializing the int again
			// row = row + 1;
			// col = col + 1;
			
			row = i / gridSize; // converts into row number
			col = i % gridSize; // converts into column number
      // mod is "how far along am I in the cycle of 6 (the limit is 6) before it resets?"
			GRID[row,col] = i;
			
		}
		Console.WriteLine($"This is a 2D integer array of: ({GRID[4,1]},{GRID[3,1]}).");
	}
	
	public static void PopulateGridNested(){
    GRID = new int[gridSize, gridSize];
    
    for (int row = 0; row < gridSize; row++)
    {
        for (int col = 0; col < gridSize; col++)
        {
            GRID[row, col] = row * gridSize + col;  
        }
    }
}
}
