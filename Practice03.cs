using System;
					
public class Program
{
	public void Main()
	{
		string car = "mustang";
		string[]cars = {"jeep", "porche", "ferrari"};
		Console.WriteLine(cars[0]);
		Console.WriteLine(cars.Length);
		
		foreach(var car in cars){
		Console.WriteLine(car);
		}
		string[] PlayerTypes = {"pawn", "pawn", "pawn"};
		foreach(var PlayerType in PlayerTypes);
		Console.WriteLine(PlayerType);
		
		for(var i = 0;i < PlayerTypes.Length; i ++){
		PlayerTypes [i] = "Queen";
		}
	}
}
