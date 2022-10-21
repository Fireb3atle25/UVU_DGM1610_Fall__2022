using System;

public class Program
{
	public Health PlayerHealth;
	public Armor helmet;
	public Weapon revolver;
	public PowerUp WeaponPowerUp;
	public void Main()
	{
		PlayerHealth = new Health();
		helmet = new Armor();
		revolver = new Weapon();
		WeaponPowerUp = new PowerUp();
		
		PlayerHealth.healthNumber++;
		revolver.ammoCount++;
		PlayerHealth.health += helmet.Protectionlevel;
		revolver.firepower += WeaponPowerUp.Powerlevel;
		Console.WriteLine(revolver.WeaponName + " it has an ammo count of " + revolver.ammoCount + ".");
		Console.WriteLine(" the revolver's firepower is now " + revolver.firepower + ", it has been upgraded.");
		Console.WriteLine( " player health is now " + PlayerHealth.healthNumber + " you have put on a helmet.");
		Console.WriteLine(" the helmet is now equipped " + helmet.Protectionlevel + " is it's protection level. ");
		
	}
}
	public class Weapon
	{
		public int ammoCount = 6;
		public string WeaponName = "revolver";
		public float firepower = 6.5f;
	}

	public class PowerUp
	{
		public float Powerlevel = 3.5f;
	}
	public class Armor
	{
	public string ArmorType = "helmet";
	public int Protectionlevel = 5;
	}

	public class Health
	{
	public string health = "PlayerHealth";
	public float healthNumber = 10.1f;
	}
