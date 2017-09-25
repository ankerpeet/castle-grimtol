using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Build
    {
        public Game MyGame;
        public Room Courtyard;
        public Player Hero;
        public void BuildGame()
        {
            //Sword build
            Item Sword = new Item("Sword", "A weapen designed for slashing and stabbing.");
            //Wand build
            Item Key = new Item("Key", "Used to unlock locked doors, duh.");
            //Potion
            Item Potion = new Item("Potion", "Using this potion will will either restore you to maximum health, or reduce your health to zero.");
            //Torch
            Item Torch = new Item("Torch", "Using this item will lighten a dark room.");
            //Food
            Item Food = new Item("Food", "Looks tasty");

            //Build Player
            Hero = new Player(100, 0);

            //Room 1 - Courtyard
            Courtyard = new Room("The Courtyard", "Quiet and empty. Maybe a little too quiet and empty." , true);
            //Room 2 Barracks
            Room Barracks = new Room("The Barracks", "Filled with sleeping soldiers. Be carefull not to wake them.", true);
            Barracks.Items.Add(Sword);
            Barracks.Items.Add(Food);
            //Room 3 - Dungeon
            Room Dungeon = new Room("The Dungeon", "Cold and dark.", false);
            Dungeon.Items.Add(Key);
            Dungeon.Items.Add(Potion);

            //Room 4 = Throne Room
            Room ThroneRoom = new Room("The Throne Room", "This room is super fancy. There's also an important looking chest over in the corner. Dang, it's locked.", true);
            ThroneRoom.Items.Add(Torch);

            //Courtyard Exits
            Courtyard.AddExit("N", ThroneRoom);
            Courtyard.AddExit("E", Dungeon);
            Courtyard.AddExit("W", Barracks);
            //Barracks exits
            Barracks.AddExit("E", Courtyard);
            //Dungeon Exits
            Dungeon.AddExit("W", Courtyard);
            //ThroneRoom Exits
            ThroneRoom.AddExit("S", Courtyard);
            

            //Start Game
            MyGame = new Game(Courtyard, Hero);
        }
    }
}
