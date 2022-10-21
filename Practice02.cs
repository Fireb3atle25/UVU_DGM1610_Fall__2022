using System;
					
public class Program
{
	public GameStates gameStates;
	public Operation MyOperator;
	public void Main()
	{
		gameStates = new GameStates();
		MyOperator = new Operation();
		MyOperator.DoMath(20, 6);
		MyOperator.Compare(100, 20);
		MyOperator.Compare(50, 50);
		MyOperator.CheckPassword("password");
		MyOperator.CheckPassword("123456");
	}
	public class Gamestates {
	public enum States {
		Starting,
		Playing,
		Ending
	}
		public States currentState = States.Starting;
	
	public void CheckState () {
	switch (currentState) {
		case States.Starting:
			Console.WriteLine("Starting");
			break;
		case States.Playing:
			Console.WriteLine("Playing");
			break;
		case States.Ending:
			Console.WriteLine("Ending");
			break;
	}
	}
	
	public class Operation{public void DoMath (int value, int value2){
	var number = value + value2;
	Console.WriteLine(number);
	}
	public void Compare ( int value, int value2) {
	if (value > value2){
	Console.WriteLine("First number is greater");
	}
		else{
		Console.WriteLine("Second number is greater");
		}
	}
		public void CheckPassword (string password) {
		if(password == "123456"){
		Console.WriteLine("correct password");
		}
			else {
		Console.WriteLine("incorrect password");
			
			
	
