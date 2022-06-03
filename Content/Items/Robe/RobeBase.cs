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

        private int dyeItem;
        private int dyeSilk;
        private int dyeThread;
        private int dyePlastic;
        private string internalName;
        private string texture;

        protected override bool CloneNewInstances => true;

        public override ModItem NewInstance(Item entity)
        {
            RobeBase instance = (RobeBase)base.NewInstance(entity);
            instance.dyeItem = dyeItem;
            instance.dyeSilk = dyeSilk;
            instance.dyeThread = dyeThread;
            instance.dyePlastic = dyePlastic;
            instance.internalName = internalName;
            instance.texture = texture;

            return instance;
        }

        public override ModItem Clone(Item newEntity)
        {
            RobeBase clone = (RobeBase)base.Clone(newEntity);
            clone.dyeItem = dyeItem;
            clone.dyeSilk = dyeSilk;
            clone.dyeThread = dyeThread;
            clone.dyePlastic = dyePlastic;
            clone.internalName = internalName;
            clone.texture = texture;

            return clone;
        }

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
