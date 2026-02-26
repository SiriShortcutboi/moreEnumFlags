using System;




//when we sue the | it combines/add them 
Powers hero = Powers.SuperStrength | Powers.Teleport;

if (hero.HasFlag(Powers.SuperStrength))
    {
        Console.WriteLine("Crushes his foe!");       
    }
if (hero.HasFlag(Powers.Flight))
    {
        Console.WriteLine("Flies around");       
    }
if (hero.HasFlag(Powers.LaserVision))
    {
        Console.WriteLine("Melting candles");       
    }
if (hero.HasFlag(Powers.Teleport))
    {
        Console.WriteLine("Teleports around");       
    }
if (hero.HasFlag(Powers.AllMight))
    {
        Console.WriteLine("Go beyond Plus Ultra");       
    }

[Flags] //attribute - a label that other code can make decision with
//ye, flags make our code extra fancy
enum Powers
{
    None = 0,
    SuperStrength = 1,
    Flight = 2,
    LaserVision = 4,
    Teleport = 8, 
    AllMight = 16,

}


/* 
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
} */