using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Rocket.API.Collections;

namespace educatalan02.AutoSaveKingModdingNetwork
{
    public class AutoSaveMain : RocketPlugin<AutoSaveConfig>
    {
        public static AutoSaveMain Instance = null;

         Func<Color> colorify = () => UnturnedChat.GetColorFromName(AutoSaveMain.Instance.Configuration.Instance.Color, Color.yellow);

        protected override void Load()
        
        {

            Instance = this;



            Rocket.Core.Logging.Logger.Log("Plugin Loaded correctly. Made by educatalan02");
            Rocket.Core.Logging.Logger.Log("If you have issues join to this discord: https://discord.gg/69C9rb6");


            InvokeRepeating("Save", Configuration.Instance.SaveInterval, Configuration.Instance.SaveInterval);
        }


        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Plugin unloaded");
            CancelInvoke("Save");
        }



        public void Save()
        {
            UnturnedChat.Say(Configuration.Instance.SaveMsg, colorify());
            Rocket.Core.Logging.Logger.Log("Saving server...!");
            SaveManager.save();
        
            
        }
        // The ability to replace it for SaveMsg
        public override TranslationList DefaultTranslations => new TranslationList()
        {
            {"Saving", "Saving server..."}
        };
    }
}
