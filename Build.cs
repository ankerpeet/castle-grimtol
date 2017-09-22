using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Build
    {
        public void BuildGame()
        {
            //Sword build
            Item Sword = new Item();
            Sword.Name = "Sword";
            Sword.Description = "A weapen designed for slashing and stabbing.";
            //Wand build
            Item MagicWand = new Item();
            MagicWand.Name = "Magic Wand";
            MagicWand.Description = "Used to cast spells for cursing and destroying enemies.";
            //Potion
            Item Potion = new Item();
            Potion.Name = "Potion";
            Potion.Description = "Using this potion will will either restore you to maximum health, or reduce your health to zero.";
            //Torch
            Item Torch = new Item();
            Torch.Name = "Torch";
            Torch.Description = "Using this item will lighten a dark room.";
            //Food
            Item Food = new Item();
            Food.Name = "Food";
            Food.Description = "Looks tasty";

            //Build Player
            Player Hero = new Player();
            Hero.Score = 0;
            Hero.Health = 100;

            //Room 1 - Courtyard
            Room Courtyard = new Room();
            Courtyard.Name = " The Courtyard";
            Courtyard.Description = "Quiet and empty. Maybe a little too quiet and empty.";
            //Room 2 Barracks
            Room Barracks = new Room();
            Barracks.Items.Add(Sword);
            Barracks.Name = "The Barracks";
            Barracks.Description = "Filled with sleeping soldiers. Be carefull not to wake them.";
            //Room 3 - Dungeon
            Room Dungeon = new Room();
            Dungeon.Items.Add(MagicWand);
            Dungeon.Items.Add(Torch);
            Dungeon.Name = "The Dongeon";
            Dungeon.Description = "Cold and dark.";
            //Room 4 = Throne Room
            Room ThroneRoom = new Room();
            ThroneRoom.Items.Add(Potion);
            ThroneRoom.Items.Add(Food);
            ThroneRoom.Name = "The Throne Room";
            ThroneRoom.Description = "This room is super fancy.";

            Game StartGame = new Game();
            StartGame.CurrentPlayer = Hero;
            StartGame.CurrentRoom = Courtyard;

        }
    }
}
