﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingConnectV2.Main.Classes
{
    class Statics
    {
        public static DiscordRpc discordRpc = new DiscordRpc();
        public static Config config = new Config();
        public static IndexModel index = JsonConvert.DeserializeObject<IndexModel>(new WebClient().DownloadString(Variables.INDEX_ENDPOINT));
    }
}
