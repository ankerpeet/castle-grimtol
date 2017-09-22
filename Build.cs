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
            Item MagicWand = new Item("Magic Wand", "Used to cast spells for cursing and destroying enemies.");
            //Potion
            Item Potion = new Item("Potion", "Using this potion will will either restore you to maximum health, or reduce your health to zero.");
            //Torch
            Item Torch = new Item("Torch", "Using this item will lighten a dark room.");
            //Food
            Item Food = new Item("Food", "Looks tasty");

            //Build Player
            Hero = new Player(100, 0);

            //Room 1 - Courtyard
            Courtyard = new Room("The Courtyard", "Quiet and empty. Maybe a little too quiet and empty.");
            //Room 2 Barracks
            Room Barracks = new Room("The Barracks", "Filled with sleeping soldiers. Be carefull not to wake them.");
            Barracks.Items.Add(Sword);
            //Room 3 - Dungeon
            Room Dungeon = new Room("The Dongeon", "Cold and dark.");
            Dungeon.Items.Add(MagicWand);
            Dungeon.Items.Add(Torch);
            //Room 4 = Throne Room
            Room ThroneRoom = new Room("The Throne Room", "This room is super fancy.");
            ThroneRoom.Items.Add(Potion);
            ThroneRoom.Items.Add(Food);

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
