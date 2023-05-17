using DungeonRpg.Services;
using System;

namespace DungeonRpg.Engine.Entities
{
	[Serializable]
    public class Race : IKey
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaleTileId { get; set; }
        public int FemaleTileId { get; set; }
    }
}
