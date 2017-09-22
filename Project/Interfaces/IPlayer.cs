using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public interface IPlayer
    {
        int Health { get; set; }
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}