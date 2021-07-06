using System;
using System.Collections.Generic;
using System.IO;

namespace Capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze STOLICE ");
            Game game = new Game();
            game.play();
            
        }
    }
}

