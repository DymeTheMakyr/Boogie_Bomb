using System.Collections;
using System.Collections.Generic;
using Boogie_Bomb.Items;
using Exiled.API.Features;
using Exiled.CustomItems;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;
using MEC;
using Exiled.API.Interfaces;

namespace Boogie_Bomb {
    public class config : IConfig {
        public bool IsEnabled {get; set; } = true;
        public bool Debug {get; set; }

        public BoogieBomb boogieBomb {get; set; } = new BoogieBomb();
    }
}
