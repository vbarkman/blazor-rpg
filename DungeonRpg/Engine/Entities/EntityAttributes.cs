using System;

namespace DungeonRpg.Engine.Entities
{
	[Serializable]
    public class EntityAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Memory { get; set; }
    }
}
