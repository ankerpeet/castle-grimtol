using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Menu
    {
        public void MainMenu()
        {
            //Game setup
            Build MyBuild = new Build();
            MyBuild.BuildGame();
            Player currentPlayer = MyBuild.Hero;
            Room currentRoom = MyBuild.Courtyard;
            Console.Clear();
            bool Playing = true;

            //While player health is above 0 and Playing is true do this loop
            while (currentPlayer.Health > 0 && Playing == true)
            {
                //Print Score Health and current room
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Player Energy: " + currentPlayer.Health + "\t" + "Score: " + currentPlayer.Score);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Current Room: " + currentRoom.Name);
                Console.WriteLine("Room Description: " + currentRoom.Description);

                //Check to see if there are items in room, then print the
                if (currentRoom.Items.Count > 0)
                {
                    Console.WriteLine("Items in room:");
                    for (int i = 0; i < currentRoom.Items.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + currentRoom.Items[i].Name + " - " + currentRoom.Items[i].Description);
                    }
                }

                if (currentPlayer.Inventory.Count > 0)
                {
                    Console.WriteLine("My Items:");
                    for (int i = 0; i < currentPlayer.Inventory.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + currentPlayer.Inventory[i].Name + " - " + currentPlayer.Inventory[i].Description);
                    }
                }

                //Get user commands
                Console.WriteLine("-----------------------------------");
                Console.Write("What would you like to do?");
                string Input = Console.ReadLine().ToUpper();

                //Quit
                if (Input == "QUIT" || Input == "Q")
                {
                    Playing = false;
                }

                //Help
                else if (Input == "HELP" || Input == "H")
                {
                    Console.Clear();
                    Console.WriteLine("Commands:");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("GO" + "\t" + "Accepts: North, East, South, West, or N, E, S, & W.");
                    Console.WriteLine("TAKE" + "\t" + "Accepts: Name of item.");
                    Console.WriteLine("USE" + "\t" + "Accepts: Name of item.");
                    Console.WriteLine("RESTART" + "\t" + "Restarts game.");
                    Console.WriteLine("QUIT" + "\t" + "Quits game.");
                    Console.WriteLine("-----------------------------------");
                }

                //Directions
                else if (Input == "GO NORTH" || Input == "N" || Input == "GO EAST" || Input == "E" || Input == "GO SOUTH" || Input == "S" || Input == "GO WEST" || Input == "W")
                {
                    //Check to see if command is valid for current room
                    Room NewRoom = MyBuild.MyGame.ChangeRoom(Input);
                    if (NewRoom != null)
                    {
                        Console.Clear();
                        currentRoom = NewRoom;
                        currentPlayer.Health -= 10;
                        if (NewRoom.Name != "The Courtyard")
                        {
                            currentPlayer.Score += 10;
                        }
                    }
                    //If command is not valid
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Nowhere to go in that direction.");
                        Console.ResetColor();
                        Console.WriteLine("-----------------------------------");
                    }
                }

                //Take Item
                else if (Input.Split(" ")[0] == "TAKE")
                {
                    if (Input.Split(" ")[1] != null)
                    {
                        for (int i = 0; i < currentRoom.Items.Count; i++)
                        {
                            Item item = currentRoom.Items[i];
                            if (item.Name.ToUpper() == Input.Split(" ")[1])
                            {
                                currentPlayer.Inventory.Add(item);
                                currentRoom.Items.Remove(item);
                                Console.Clear();
                                Console.WriteLine("-----------------------------------");
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You now have a " + item.Name);
                                Console.ResetColor();
                                Console.WriteLine("-----------------------------------");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------");
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Not a valid item, or you do not have access to this item here.");
                                Console.ResetColor();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Not a valid item, or you do not have access to this item here.");
                        Console.ResetColor();
                        Console.WriteLine("-----------------------------------");
                    }
                }

                //If invalid command
                else
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Not a valid input. Type Help for a list of commands.");
                    Console.ResetColor();
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }
}
