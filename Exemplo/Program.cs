using System;
 
//namespace CSharpTutA.cs
namespace Exemplo;

class Program
{
    /*
    Bob Attacks Maximus and Deals 74 Damage
    Maximus Has 69 Health

    Maximus Attacks Bob and Deals 6 Damage
    Bob Has 6 Health

    Bob Attacks Maximus and Deals 48 Damage
    Maximus Has 21 Health

    Maximus Attacks Bob and Deals 48 Damage
    Bob Has -42 Health

    Bob has Died and Maximus is Victorious

    Game Over
    */

    static void Main(string[] args)
    {
        Warrior maximus = new Warrior("Maverick", 1000, 120, 40); //Alteração realizara por phidalgo
        Warrior bob = new Warrior("Iceman", 1000, 120, 40); //Alteração realizada por phidalgo

        Battle.StartFight(maximus, bob);

        Console.ReadLine();

    }
    
}

