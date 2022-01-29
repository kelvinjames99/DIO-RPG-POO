using System;
using DOTNET___POO.src.Entities;

namespace DOTNET___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight(749, 72, "Arus", 42, "Knight");
            Console.WriteLine("\n" + arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(arus.Attack(2));

            Ninja wedge = new Ninja(574, 89, "Wedge", 42, "Ninja");
            wedge.AddItem("Shuriken");
            Console.WriteLine("\n" + wedge);
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(wedge.Attack("Shuriken"));//item é removido do inventário
            Console.WriteLine(wedge.Attack("Shuriken"));

            Wizard jenica = new Wizard(601, 482, "Jenica", 42, "White Wizard");
            jenica.LearnMagic("Holy");
            Console.WriteLine("\n" + jenica);
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(jenica.Attack("Holy"));
            Console.WriteLine(jenica.Attack("Firaga"));


            Wizard topapa = new Wizard(385, 641, "Topapa", 42, "Black Wizard");
            topapa.LearnMagic("Firaga");
            Console.WriteLine("\n" + topapa);
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(topapa.Attack("Firaga"));
            Console.WriteLine(topapa.Attack("Blizzaga"));
        }
    }
}
