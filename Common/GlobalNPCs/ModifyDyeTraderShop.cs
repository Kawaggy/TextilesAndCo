using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Common.Systems;

namespace TextilesAndCo.Common.GlobalNPCs
{
    public class ModifyDyeTraderShop : GlobalNPC
    {
        public override bool AppliesToEntity(NPC entity, bool lateInstantiation)
        {
            return entity.type == NPCID.DyeTrader;
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.DyeTrader)
            {
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Red, ItemID.RedDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Orange, ItemID.OrangeDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Yellow, ItemID.YellowDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Lime, ItemID.LimeDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Green, ItemID.GreenDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Teal, ItemID.TealDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Cyan, ItemID.CyanDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.SkyBlue, ItemID.SkyBlueDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Blue, ItemID.BlueDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Purple, ItemID.PurpleDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Violet, ItemID.VioletDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Pink, ItemID.PinkDye, ref nextSlot);
                AddDyeToShop(shop, ObtainedDyesSystem.Dyes.Black, ItemID.BlackDye, ref nextSlot);
            }
        }

        internal static void AddDyeToShop(Chest shop, int gotDyeIndex, int itemID, ref int nextSlot)
        {
            if (ObtainedDyesSystem.gotDye[gotDyeIndex])
            {
                shop.item[nextSlot].SetDefaults(itemID);
                shop.item[nextSlot].shopCustomPrice = Item.buyPrice(gold: 1);
                nextSlot++;
            }
        }
    }
}
