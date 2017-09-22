using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }

        public Game(Room currentRoom, Player currentPLayer)
        {
            CurrentPlayer = currentPLayer;
            CurrentRoom = currentRoom;
        }
        public Room ChangeRoom(string direction)
        {
            CurrentRoom = CurrentRoom.Exits[direction];
            return CurrentRoom;
        }
        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public void Setup()
        {
            throw new System.NotImplementedException();
        }

        public void UseItem(string itemName)
        {
            throw new System.NotImplementedException();
        }
    }
}