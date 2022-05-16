using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Content.Items.Robe;
using TextilesAndCo.Content.Items.Silk;
using TextilesAndCo.Content.Items.Thread;
using TextilesAndCo.Content.Items.Yarn;

namespace TextilesAndCo
{
	public class TextilesAndCo : Mod
	{
        public static TextilesAndCo Instance;

        public override void Load()
        {
            Instance = this;

            AddContent(new WhiteSilk(null));
            AddContent(new WhiteThread(null));
            AddContent(new WhiteYarn(null));
            AddContent(new WhiteRobe(null));

            AddItemSet(ItemID.RedDye, "Red");
            AddItemSet(ItemID.OrangeDye, "Orange");
            AddItemSet(ItemID.YellowDye, "Yellow");
            AddItemSet(ItemID.LimeDye, "Lime");
            AddItemSet(ItemID.GreenDye, "Green");
            AddItemSet(ItemID.TealDye, "Teal");
            AddItemSet(ItemID.CyanDye, "Cyan");
            AddItemSet(ItemID.SkyBlueDye, "SkyBlue");
            AddItemSet(ItemID.BlueDye, "Blue");
            AddItemSet(ItemID.PurpleDye, "Purple");
            AddItemSet(ItemID.VioletDye, "Violet");
            AddItemSet(ItemID.PinkDye, "Pink");
            AddItemSet(ItemID.BlackDye, "Black");
            AddItemSet(ItemID.BrownDye, "Brown");
        }

        public override void Unload()
        {
            Instance = null;
        }

        internal void AddItemSet(int dyeType, string dyeName)
        {
            AddContent(new SilkBase(dyeType, dyeName + "Silk", "TextilesAndCo/Content/Items/Silk/" + dyeName + "Silk"));
            AddContent(new ThreadBase(dyeType, dyeName + "Thread", "TextilesAndCo/Content/Items/Thread/" + dyeName + "Thread"));
            AddContent(new YarnBase(dyeType, dyeName + "Yarn", "TextilesAndCo/Content/Items/Yarn/" + dyeName + "Yarn"));
            AddContent(new RobeBase(dyeType, Find<ModItem>(dyeName + "Silk").Type, dyeName + "Robe", "TextilesAndCo/Content/Items/Robe/" + dyeName + "Robe"));
        }
    }
}