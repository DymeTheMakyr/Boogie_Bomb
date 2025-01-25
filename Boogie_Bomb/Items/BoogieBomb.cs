using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AdminToys;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Map;
using Exiled.API.Features;
using AudioPlayer;
using CommandSystem.Commands.RemoteAdmin;
using CustomPlayerEffects;
using Exiled.API.Features.DynamicEvents;
using Exiled.API.Features.Toys;
using Exiled.Events.EventArgs.Scp173;
using MEC;
using PluginAPI.Roles;
using SCPSLAudioApi.AudioCore;
using UnityEngine;
using Light = Exiled.API.Features.Toys.Light;

namespace Boogie_Bomb.Items {
    
    public class BoogieBomb : CustomGrenade {
        public override ItemType Type { get; set; } = ItemType.GrenadeFlash;
        public override uint Id { get; set; } = 32;
        public override string Name { get; set; } = "BoogieBomb";
        public override string Description { get; set; } = "Gives all humans and SCPs a disco fever for a few seconds.";
        public override float Weight { get; set; } = 0.35f;

        public float Range = 4f;
        
        public override SpawnProperties SpawnProperties { get; set; } = new() {
            Limit = 10,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>() {
                new() {
                    Chance = 100f,
                    Location = SpawnLocationType.InsideLczWc
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.Inside330
                },
                new() {
                Chance = 100,
                Location = SpawnLocationType.InsideGr18
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideHczArmory
                },
                new() {
                Chance = 100,
                Location = SpawnLocationType.Inside079Secondary
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideLczArmory
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideEscapeSecondary
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.Inside049Armory
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.Inside173Armory
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.Inside330Chamber
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.Inside914
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideGateA
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideGateB
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideGr18
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideIntercom
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideLczCafe
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideServersBottom
                },
                new() {
                    Chance = 100,
                    Location = SpawnLocationType.InsideNukeArmory
                }
            }
        };
        
        public override bool ExplodeOnCollision { get; set; } = true;
        public override float FuseTime { get; set; } = 5f;

        protected override void OnExploding(ExplodingGrenadeEventArgs ev) {
            ev.IsAllowed = false;
            Light light = Light.Create(ev.Position + .2f*Vector3.up, Vector3.one, Vector3.one, true, new Color(2, 0, 0,2));
            List<Player> players =  Player.List.Where(x => (x.Position-ev.Position).magnitude <= Range).ToList();
            foreach (Player p in players) {p.EnableEffect(EffectType.Exhausted, 100, 3.13f, false);}
            AudioPlayer.API.SoundPlayer.PlaySoundAtPlace("dtyd.ogg", ev.Position, Range*1.5f, "DTYD", ev.Player.Id + 40, false);
            Timing.RunCoroutine(RGBLight(light));
        }

        IEnumerator<float> RGBLight(Light light) {
            int lightColor = 0;
            for (int i = 0; i < 8; i++) {
                yield return Timing.WaitForSeconds(3.13f / 8f);
                lightColor += 1;
                lightColor %= 3;
                char[] tempChar = Mathf.Pow(10, lightColor).ToString("000").ToCharArray();
                light.Color = new Color(2 * (tempChar[0] - '0'), 2 * (tempChar[1] - '0'), 2 * (tempChar[2] - '0'), 2);
            }
            light.Destroy();
            yield return 0;
        }

        public void OnBlinking(BlinkingEventArgs ev) {
            if (ev.Player.IsEffectActive<Ensnared>()) ev.IsAllowed = false;
        }
    }
}