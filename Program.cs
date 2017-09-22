using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Start Game Build
            Build MyBuild = new Build();
            MyBuild.BuildGame();

            Game StartGame = new Game();
            Console.WriteLine(StartGame.CurrentRoom.Name);
            Console.WriteLine(StartGame.CurrentRoom.Description);

        }
    }
}
