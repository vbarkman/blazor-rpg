using DungeonRpg.Services;
using System;

namespace DungeonRpg.Engine.Entities
{
	[Serializable]
    public class Player : Character, IKey
    {
        [Obsolete("Hash this shit!")]
        public string Password { get; set; }
        public bool IsAdministrator { get; set; }

        public override int GetTileId() => Gender == Genders.Male ? Race.MaleTileId : Race.FemaleTileId;
    }
}
