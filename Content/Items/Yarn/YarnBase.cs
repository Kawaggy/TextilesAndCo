using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Core.IDs;

namespace TextilesAndCo.Content.Items.Yarn
{
    public class YarnBase : ModItem
    {
        public const int ResultCount = 30;

        private int dyeItem;
        private string internalName;
        private string texture;

        protected override bool CloneNewInstances => true;

        public override ModItem NewInstance(Item entity)
        {
            YarnBase instance = (YarnBase)base.NewInstance(entity);
            instance.dyeItem = dyeItem;
            instance.internalName = internalName;
            instance.texture = texture;

            return instance;
        }

        public override ModItem Clone(Item newEntity)
        {
            YarnBase clone = (YarnBase)base.Clone(newEntity);
            clone.dyeItem = dyeItem;
            clone.internalName = internalName;
            clone.texture = texture;

            return clone;
        }

        public YarnBase(int dyeItem, string internalName, string texture)
        {
            this.dyeItem = dyeItem;
            this.internalName = internalName;
            this.texture = texture;
        }

        public override string Name => internalName;

        public override string Texture => texture;

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 75;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.width = 18;
            Item.height = 16;
            Item.value = Item.sellPrice(silver: 10);
        }

        public override void AddRecipes()
        {
            CreateRecipe(ResultCount)
                .AddIngredient(YarnID.White, ResultCount)
                .AddIngredient(dyeItem)
                .AddTile(TileID.DyeVat)
                .Register();
        }
    }
}
