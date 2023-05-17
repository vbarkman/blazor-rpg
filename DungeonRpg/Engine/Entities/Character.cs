using System;

namespace DungeonRpg.Engine.Entities
{
	[Serializable]
    public abstract class Character : Entity
    {
        public Genders Gender { get; set; }
        public Race Race { get; set; } = new Race();
    }
}
