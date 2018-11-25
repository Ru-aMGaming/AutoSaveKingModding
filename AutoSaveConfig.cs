using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using UnityEngine;

namespace educatalan02.AutoSaveKingModdingNetwork
{
    public class AutoSaveConfig : IRocketPluginConfiguration

    {
        public float SaveInterval;
        public string Color;
        public string SaveMsg;

        public void LoadDefaults()
        {
            SaveMsg = "Server saving...";
            SaveInterval = 600f; 
            Color = "yellow";
        }
    }
}
