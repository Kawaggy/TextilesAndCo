using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TextilesAndCo.Content.Items.Silk
{
    public class WhiteSilk : ModItem
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

        public WhiteSilk(object _)
        {

        }

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.width = 26;
            Item.height = 28;
            Item.value = Item.buyPrice(silver: 1);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Cobweb, 7)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
