using Exiled.API.Features;
using Exiled.CustomItems.API;
using Scp173 = Exiled.Events.Handlers.Scp173;

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
            Scp173.Blinking += Config.boogieBomb.OnBlinking;
        }

        private void UnregisterEvents() {
            Scp173.Blinking -= Config.boogieBomb.OnBlinking;
        }

        private void RegisterItems() {
            Config.boogieBomb.Type = ItemType.GrenadeFlash;
            Config.boogieBomb.Register();
        }

        private void UnregisterItems() {
            Config.boogieBomb.Unregister();
        }
    }
}
