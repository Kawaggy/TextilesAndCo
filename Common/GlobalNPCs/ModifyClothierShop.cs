using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TextilesAndCo.Common.GlobalNPCs
{
    public class ModifyClothierShop : GlobalNPC
    {
        public override bool AppliesToEntity(NPC entity, bool lateInstantiation)
        {
            return entity.type == NPCID.Clothier;
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Clothier)
            {
                for (int i = 0; i < shop.item.Length; i++)
                {
                    if (shop.item[i].type == ItemID.PinkThread || shop.item[i].type == ItemID.BlackThread)
                    {
                        shop.item[i].TurnToAir();
                    }
                }

                int newIndex = 0;

                for (int i = 0; i < shop.item.Length; i++)
                {
                    if (shop.item[i].IsAir)
                    {
                        for (int j = i; j < shop.item.Length; j++)
                        {
                            if (!shop.item[j].IsAir)
                            {
                                shop.item[i] = shop.item[j].Clone();
                                shop.item[j].TurnToAir();
                                newIndex++;
                                break;
                            }
                        }
                    }
                }

                nextSlot -= newIndex;
            }
        }
    }
}
