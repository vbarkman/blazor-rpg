using System;

namespace DungeonRpg.Engine.Entities
{
	[Serializable]
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public int TileId { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public EntityAttributes Attributes { get; set; } = new EntityAttributes();
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public (int X, int Y) Position = (0, 0);
        public Guid CurrentMapId { get; set; }

        public virtual int GetTileId() => TileId;

    }
}
