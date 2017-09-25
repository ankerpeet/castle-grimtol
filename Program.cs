using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool Running = true;
            while (Running)
            {
                //Start Game Build
                Menu Main = new Menu();
                Main.MainMenu();
                Console.WriteLine("Game Over!");
                Console.WriteLine("Would you like to play again? (Y/N)");
                string Input = Console.ReadLine();
                if (Input.ToUpper() == "N")
                {
                    Running = false;
                }
            }
        }
    }
}
