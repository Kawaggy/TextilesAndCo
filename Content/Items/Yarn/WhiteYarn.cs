using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TextilesAndCo.Content.Items.Yarn
{
    public class WhiteYarn : ModItem
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

        public WhiteYarn(object _)
        {

        }

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 75;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.width = 18;
            Item.height = 16;
            Item.value = Item.buyPrice(silver: 1);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Cobweb, 3)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
