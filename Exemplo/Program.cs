using System;
// Alteração realizada por Rafael Brunello
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
<<<<<<< HEAD
        Warrior maximus = new Warrior("Maverick", 1000, 120, 40); //Alteração realizara por phidalgo
        Warrior bob = new Warrior("Iceman", 1000, 120, 40); //Alteração realizada por phidalgo
=======
        Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
        Warrior bob = new Warrior("Joao", 1000, 120, 40); // Outra alteração feita por Rafael Brunello
>>>>>>> 6cfd86026d3bffb970d3fdeb584d2423f2d023a0

        Battle.StartFight(maximus, bob);

        Console.ReadLine();

    }
    
}

