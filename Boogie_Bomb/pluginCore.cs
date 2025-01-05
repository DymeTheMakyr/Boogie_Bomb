using System.Collections;
using System.Collections.Generic;
using Boogie_Bomb.Items;
using Exiled.API.Features;
using Exiled.CustomItems;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;
using MEC;

namespace Boogie_Bomb {
    public class pluginCore : Plugin<Config> {
        public BoogieBomb bombItem;
        
        public override void OnEnabled() {
            base.OnEnabled();
            RegisterEvents();
            RegisterItems();
        }

        public override void OnDisabled() {
            base.OnDisabled();
            UnregisterEvents();
            UnregisterItems();
        }

        private void RegisterEvents() {
            
        }

        private void UnregisterEvents() {
            
        }

        private void RegisterItems() {
            
        }

        private void UnregisterItems() {
            Items.BoogieBomb.Unregister();
            bombItem = null;
        }
    }
}