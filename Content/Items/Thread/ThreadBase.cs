using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Core.IDs;

namespace TextilesAndCo.Content.Items.Thread
{
    public class ThreadBase : ModItem
    {
        public const int ResultCount = 30;

        private int dyeItem;
        private string internalName;
        private string texture;

        protected override bool CloneNewInstances => true;

        public override ModItem NewInstance(Item entity)
        {
            ThreadBase instance = (ThreadBase)base.NewInstance(entity);
            instance.dyeItem = dyeItem;
            instance.internalName = internalName;
            instance.texture = texture;

            return instance;
        }

        public override ModItem Clone(Item newEntity)
        {
            ThreadBase clone = (ThreadBase)base.Clone(newEntity);
            clone.dyeItem = dyeItem;
            clone.internalName = internalName;
            clone.texture = texture;

            return clone;
        }

        public ThreadBase(int dyeItem, string internalName, string texture)
        {
            this.dyeItem = dyeItem;
            this.internalName = internalName;
            this.texture = texture;
        }

        public override string Name => internalName;

        public override string Texture => texture;

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1998;
            Item.width = 28;
            Item.height = 20;
            Item.value = Item.sellPrice(silver: 10);
        }

        public override void AddRecipes()
        {
            CreateRecipe(ResultCount)
                .AddIngredient(ThreadID.White, ResultCount)
                .AddIngredient(dyeItem)
                .AddTile(TileID.DyeVat)
                .Register();
        }
    }
}
