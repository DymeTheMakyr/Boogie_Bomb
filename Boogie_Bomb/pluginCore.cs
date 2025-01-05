using System.Collections;
using System.Collections.Generic;
using Boogie_Bomb.Items;
using Exiled.API.Features;
using Exiled.CustomItems;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;
using MEC;

namespace Boogie_Bomb {
    public class pluginCore : Plugin<config> {
        public static pluginCore Instance;
      
        public override void OnEnabled() {
            base.OnEnabled();
            Instance = this;
            RegisterEvents();
            RegisterItems();
        }

        public override void OnDisabled() {
            base.OnDisabled();
            UnregisterEvents();
            UnregisterItems();
            Instance = null;
        }

        private void RegisterEvents() {
            
        }

        private void UnregisterEvents() {
            
        }

        private void RegisterItems() {
            Config.boogieBomb.Register();
        }

        private void UnregisterItems() {
            Config.boogieBomb.Unregister();
        }
    }
}
