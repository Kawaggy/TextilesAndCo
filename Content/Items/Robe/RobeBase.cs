using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Core.IDs;

namespace TextilesAndCo.Content.Items.Robe
{
    public class RobeBase : ModItem
    {
        public const int ResultCount = 1;

        private readonly int dyeItem;
        private readonly int dyeSilk;
        private readonly int dyeThread;
        private readonly int dyePlastic;
        private readonly string internalName;
        private readonly string texture;
       
        public RobeBase(int dyeItem, int dyeSilk, int dyeThread, int dyePlastic, string internalName, string texture)
        {
            this.dyeItem = dyeItem;
            this.dyeSilk = dyeSilk;
            this.dyeThread = dyeThread;
            this.dyePlastic = dyePlastic;
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
                .AddIngredient(RobeID.White, ResultCount)
                .AddIngredient(dyeItem)
                .AddTile(TileID.DyeVat)
                .Register();

            CreateRecipe(ResultCount)
                .AddIngredient(dyeSilk, 7)
                .AddIngredient(dyeThread, 20)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
