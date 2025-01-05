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
        public static pluginCore;
      
        public override void OnEnabled() {
            base.OnEnabled();
            pluginCore = this;
            RegisterEvents();
            RegisterItems();
        }

        public override void OnDisabled() {
            base.OnDisabled();
            UnregisterEvents();
            UnregisterItems();
            pluginCore = null;
        }

        private void RegisterEvents() {
            
        }

        private void UnregisterEvents() {
            
        }

        private void RegisterItems() {
            Config.BoogieBomb.Register();
        }

        private void UnregisterItems() {
            Config.BoogieBomb.Unregister();
        }
    }
}
