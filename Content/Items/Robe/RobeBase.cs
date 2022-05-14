using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TextilesAndCo.Content.Items.Robe
{
    public class RobeBase : ModItem
    {
        public const int ResultCount = 1;

        private readonly int dyeItem;
        private readonly int alternativeSilk;
        private readonly string internalName;
        private readonly string texture;
       
        public RobeBase(int dyeItem, int alternativeSilk, string internalName, string texture)
        {
            this.dyeItem = dyeItem;
            this.alternativeSilk = alternativeSilk;
            this.internalName = internalName;
            this.texture = texture;
        }

        public override string Name => internalName;

        public override string Texture => texture;

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 28;
            Item.value = Item.sellPrice(silver: 10);
        }

        public override void AddRecipes()
        {
            CreateRecipe(ResultCount)
                .AddIngredient(ModContent.ItemType<WhiteRobe>(), ResultCount)
                .AddIngredient(dyeItem)
                .AddTile(TileID.DyeVat)
                .Register();

            CreateRecipe(1)
                .AddIngredient(alternativeSilk, 7)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
