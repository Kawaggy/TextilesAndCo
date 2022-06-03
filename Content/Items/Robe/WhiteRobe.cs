using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Content.Items.Silk;
using TextilesAndCo.Core.IDs;

namespace TextilesAndCo.Content.Items.Robe
{
    public class WhiteRobe : ModItem
    {
        protected override bool CloneNewInstances => true;

        public override ModItem NewInstance(Item entity)
        {
            return base.NewInstance(entity);
        }

        public override ModItem Clone(Item newEntity)
        {
            return base.Clone(newEntity);
        }

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
                .AddIngredient(SilkID.White, 7)
                .AddIngredient(ThreadID.White, 20)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
