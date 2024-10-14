using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;

namespace Boogie_Bomb.Items {
    [CustomItem(ItemType.GrenadeFlash)]
    public class BoogieBomb : CustomGrenade {
        public override uint Id { get; set; } = 32;
        public override string Name { get; set; } = "BoogieBomb";
        public override string Description { get; set; } = "Gives all humans and SCPs a disco fever for a few seconds.";
        public override float Weight { get; set; } = 0.35f;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties() {
            Limit = 10,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>() {
                new DynamicSpawnPoint() {
                    Chance = 10.1f,
                    Location = SpawnLocationType.InsideLczWc
                },
                new DynamicSpawnPoint() {
                    Chance = 15,
                    Location = SpawnLocationType.Inside330
                },
                new DynamicSpawnPoint() {
                Chance = 15,
                Location = SpawnLocationType.InsideGr18
                },
                new DynamicSpawnPoint() {
                    Chance = 25,
                    Location = SpawnLocationType.InsideHczArmory
                },
                new DynamicSpawnPoint() {
                Chance = 100,
                Location = SpawnLocationType.Inside079Secondary
                },
                new DynamicSpawnPoint() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideLczArmory
                },
                new DynamicSpawnPoint() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideEscapeSecondary
                }
            }
        };
        
        public override bool ExplodeOnCollision { get; set; } = true;
        public override float FuseTime { get; set; } = 5f;
        
        
    }
}