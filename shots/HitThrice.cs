using System;
					
public class Program
{
	public static int BONK_INT = 0;
	public static bool BONK_THRICE;
	public static int BONK_MAX = 3;
	public static int CURRENT_PATCH = 0;
	public static int MAX_PATCH = 2;
	public static int TOTAL_HITS = 0;
	
	public static void Main()
	{
		HitThrice();
		
		if (BONK_INT == BONK_MAX) {
				Console.WriteLine("You've been hit thrice! I'll heal ya. \n");
				if (CURRENT_PATCH != MAX_PATCH){
					PatchInjuries();
				}		
		
		Console.WriteLine($"Total sustained hits: {TOTAL_HITS}");
			
		for (int i = 0; i < CURRENT_PATCH; i++){
				HitThrice();
				if (CURRENT_PATCH != MAX_PATCH){
					PatchInjuries();
				}	
			}
		}
	}
	
	public static void BonkOnce(){
		BONK_INT++;
		Console.WriteLine("Bonk!\n");
		TOTAL_HITS++;
		if (BONK_INT == 3){
			BONK_THRICE = true;	
		}
	}
	
	public static void PatchInjuries(){
		if (CURRENT_PATCH < 2) {
			Console.WriteLine("Let me heal that up.\n");	
			CURRENT_PATCH++;
		} else if (CURRENT_PATCH == 2) {
			Console.WriteLine("No more healing, after this.\n");
		} else {
			Console.WriteLine("All out of healing.\n");	
		}
	}
	
public static void HitThrice(){
    BONK_INT = 0;
    BONK_THRICE = false;
    while (!BONK_THRICE) {
        BonkOnce();	
    }	
}
	
}
