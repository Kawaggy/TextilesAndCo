using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TextilesAndCo.Content.Items.Thread
{
    public class WhiteThread : ModItem
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

        public WhiteThread(object _)
        {

        }

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1998;
            Item.width = 28;
            Item.height = 20;
            Item.value = Item.buyPrice(silver: 1);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood)
                .AddIngredient(ItemID.Cobweb, 3)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
