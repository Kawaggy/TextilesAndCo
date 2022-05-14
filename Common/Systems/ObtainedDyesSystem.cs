using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace TextilesAndCo.Common.Systems
{
    public class ObtainedDyesSystem : ModSystem
    {
        internal const string gotDyeSaveDataName = "GotDyes";

        public class Dyes
        {
            public const int Red = 0;
            public const int Orange = 1;
            public const int Yellow = 2;
            public const int Lime = 3;
            public const int Green = 4;
            public const int Teal = 5;
            public const int Cyan = 6;
            public const int SkyBlue = 7;
            public const int Blue = 8;
            public const int Purple = 9;
            public const int Violet = 10;
            public const int Pink = 11;
            public const int Black = 12;
        }

        public static bool[] gotDye;
        public override void OnWorldLoad()
        {
            gotDye = new bool[13];
        }

        public override void PostUpdateWorld()
        {
            bool[] oldCheck = gotDye;

            for (int i = 0; i < Main.maxPlayers; i++)
            {
                Player player = Main.player[i];
                if (player.active)
                {
                    CheckIfHasDye(player, Dyes.Red, ItemID.RedDye);
                    CheckIfHasDye(player, Dyes.Orange, ItemID.OrangeDye);
                    CheckIfHasDye(player, Dyes.Yellow, ItemID.YellowDye);
                    CheckIfHasDye(player, Dyes.Lime, ItemID.LimeDye);
                    CheckIfHasDye(player, Dyes.Green, ItemID.GreenDye);
                    CheckIfHasDye(player, Dyes.Teal, ItemID.TealDye);
                    CheckIfHasDye(player, Dyes.Cyan, ItemID.CyanDye);
                    CheckIfHasDye(player, Dyes.SkyBlue, ItemID.SkyBlueDye);
                    CheckIfHasDye(player, Dyes.Blue, ItemID.BlueDye);
                    CheckIfHasDye(player, Dyes.Purple, ItemID.PurpleDye);
                    CheckIfHasDye(player, Dyes.Violet, ItemID.VioletDye);
                    CheckIfHasDye(player, Dyes.Pink, ItemID.PinkDye);
                    CheckIfHasDye(player, Dyes.Black, ItemID.BlackDye);
                }
            }

            for (int i = 0; i < gotDye.Length; i++)
            {
                if (oldCheck[i] != gotDye[i])
                {
                    NetMessage.SendData(MessageID.WorldData);
                    break;
                }
            }
        }

        internal static void CheckIfHasDye(Player player, int gotDyeIndex, int itemID)
        {
            if (!gotDye[gotDyeIndex])
            {
                if (player.HasItem(itemID))
                {
                    gotDye[gotDyeIndex] = true;
                }
            }
        }

        public override void SaveWorldData(TagCompound tag)
        {
            TagCompound saveData = new();
            for (int i = 0; i < gotDye.Length; i++)
            {
                if (gotDye[i])
                    saveData.Add("gotDye_" + i, true);
            }

            tag.Add(gotDyeSaveDataName, saveData);
        }

        public override void LoadWorldData(TagCompound tag)
        {
            TagCompound saveData = tag.Get<TagCompound>(gotDyeSaveDataName);

            for (int i = 0; i < gotDye.Length; i++)
            {
                gotDye[i] = saveData.ContainsKey("gotDye_" + i);
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            var flags = new BitsByte();
            flags[0] = gotDye[Dyes.Red];
            flags[1] = gotDye[Dyes.Orange];
            flags[2] = gotDye[Dyes.Yellow];
            flags[3] = gotDye[Dyes.Lime];
            flags[4] = gotDye[Dyes.Green];
            flags[5] = gotDye[Dyes.Teal];
            flags[6] = gotDye[Dyes.Cyan];
            flags[7] = gotDye[Dyes.SkyBlue];

            writer.Write(flags);

            flags = new BitsByte();
            flags[0] = gotDye[Dyes.Blue];
            flags[1] = gotDye[Dyes.Purple];
            flags[2] = gotDye[Dyes.Violet];
            flags[3] = gotDye[Dyes.Pink];
            flags[4] = gotDye[Dyes.Black];

            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();

            gotDye[Dyes.Red] = flags[0];
            gotDye[Dyes.Orange] = flags[1];
            gotDye[Dyes.Yellow] = flags[2];
            gotDye[Dyes.Lime] = flags[3];
            gotDye[Dyes.Green] = flags[4];
            gotDye[Dyes.Teal] = flags[5];
            gotDye[Dyes.Cyan] = flags[6];
            gotDye[Dyes.SkyBlue] = flags[7];

            flags = reader.ReadByte();

            gotDye[Dyes.Blue] = flags[0];
            gotDye[Dyes.Purple] = flags[1];
            gotDye[Dyes.Violet] = flags[2];
            gotDye[Dyes.Pink] = flags[3];
            gotDye[Dyes.Black] = flags[4];
        }
    }
}
