using Boogie_Bomb.Items;
using Exiled.Loader;
using Exiled.API.Features;
using Exiled.CustomItems.API;

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
            bombItem = new BoogieBomb();
            bombItem.Register();
        }

        private void UnregisterItems() {
            bombItem.Unregister();
            bombItem = null;
        }
    }
}