using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Content.Items.Silk;

namespace TextilesAndCo.Content.Items.Robe
{
    public class WhiteRobe : ModItem
    {
        public WhiteRobe(object _)
        {

        }

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.width = 30;
            Item.height = 28;
            Item.value = Item.buyPrice(silver: 1);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<WhiteSilk>(), 7)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
