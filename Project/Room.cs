using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ViewItems { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();

        public Room(string name, string description, bool view)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
            ViewItems = view;

        }
        public void AddExit(string exit, Room newRoom)
        {
            Exits.Add(exit, newRoom);
        }
        public void UseItem(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}