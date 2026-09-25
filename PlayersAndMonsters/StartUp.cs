using System;

namespace PlayersAndMonsters;

public class StartUp
{
    public static void Main(string[] args)
    {
        BladeKnight bladeKnight = new BladeKnight(username: "Oktavian", level: 12);
        
        Console.WriteLine(bladeKnight);
    }
}