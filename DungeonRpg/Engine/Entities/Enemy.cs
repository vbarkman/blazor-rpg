using DungeonRpg.Services;
using System;

namespace DungeonRpg.Engine.Entities
{
	[Serializable]
    public class Enemy : Entity, IKey
    {
        public enum EnemyAiState { Idle, Attacking, Dead };
        public EnemyAiState State { get; set; } = EnemyAiState.Idle;
        public bool AiEnabled { get; set; }
        public (int X, int Y) InitialPosition = (0, 0);
        public int WalkRadius { get; set; }
        public bool IsAggressive { get; set; }

        internal void AiTick(Map map)
        {
            if (AiEnabled)
            {
                // move to some other class??
                switch (State)
                {
                    case EnemyAiState.Attacking:
                        // No player nearby? => Idle
                        // Walk to the player
                        // Attack the player
                        break;
                    case EnemyAiState.Idle:
                        // Is a player nearby and aggressive? => Attacking
                        EnemyAi.ExecuteRandomWalkInRadius(this, map);
                        break;
                    case EnemyAiState.Dead:
                        // Add a respawn time
                        Health = MaxHealth;
                        State = EnemyAiState.Idle;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
