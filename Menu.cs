using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Menu
    {
        public void MainMenu()
        {
            Build MyBuild = new Build();
            MyBuild.BuildGame();
            Player currentPlayer = MyBuild.Hero;
            Room currentRoom = MyBuild.Courtyard;
            Console.Clear();
            while (currentPlayer.Health > 0)
            {

                Console.WriteLine("Player Health: " + currentPlayer.Health + "\t" + "Score: " + currentPlayer.Score);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Current Room: " + currentRoom.Name);
                Console.WriteLine("Room Description: " + currentRoom.Description);
                Console.WriteLine("-----------------------------------");
                Console.Write("What would you like to do?");
                string Input = Console.ReadLine().ToUpper();
                if (Input == "QUIT" || Input == "Q")
                {
                    currentPlayer.Health = 0;
                }
                else if (Input == "HELP" || Input == "H")
                {
                    Console.Clear();
                    Console.WriteLine("Commands:");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("GO" + "\t" + "Accepts: North, East, South, West, or N, E, S, & W.");
                    Console.WriteLine("TAKE" + "\t" + "Accepts: Name of item.");
                    Console.WriteLine("USE" + "\t" + "Accepts: Name of item.");
                    Console.WriteLine("QUIT" + "\t" + "Quits game.");
                    Console.WriteLine("-----------------------------------");
                }
                else if (Input == "GO NORTH" || Input == "N" || Input == "GO EAST" || Input == "E" || Input == "GO SOUTH" || Input == "S" || Input == "GO WEST" || Input == "W")
                {
                    Room NewRoom = MyBuild.MyGame.ChangeRoom(Input);
                    currentRoom = NewRoom;
                }
            }
        }
    }
}
