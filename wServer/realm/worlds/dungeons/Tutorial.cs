﻿using wServer.networking;

namespace wServer.realm.worlds
{
    public class Tutorial : World
    {
        public Tutorial(bool isLimbo)
        {
            Id = TUT_ID;
            Name = "Tutorial";
            Background = 0;
            Difficulty = 0;
            IsLimbo = isLimbo;
            SetMusic("world/Overworld");
        }

        protected override void Init()
        {
            if (!IsLimbo)
                base.FromWorldMap(
                    typeof (RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.dungeons.tutorial.wmap"));
        }

        public override World GetInstance(Client client)
        {
            return Manager.AddWorld(new Tutorial(false));
        }
    }
}