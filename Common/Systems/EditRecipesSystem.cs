using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Content.Items.Robe;
using TextilesAndCo.Content.Items.Silk;

namespace TextilesAndCo.Common.Systems
{
    public class EditRecipesSystem : ModSystem
    {
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.TryGetIngredient(ItemID.PinkThread, out Item pink))
                {
                    int stack = pink.Clone().stack * 6;
                    pink.SetDefaults(Mod.Find<ModItem>("PinkThread").Type);
                    pink.stack = stack;
                }

                if (recipe.TryGetIngredient(ItemID.BlackThread, out Item black))
                {
                    int stack = black.Clone().stack * 6;
                    black.SetDefaults(Mod.Find<ModItem>("BlackThread").Type);
                    black.stack = stack;
                }

                if (recipe.TryGetIngredient(ItemID.GreenThread, out Item green))
                {
                    int stack = green.Clone().stack * 6;
                    green.SetDefaults(Mod.Find<ModItem>("GreenThread").Type);
                    green.stack = stack;
                }

                if (recipe.TryGetResult(ItemID.GreenThread, out Item _))
                {
                    recipe.RemoveRecipe();
                }

                if (recipe.TryGetIngredient(ItemID.Robe, out Item robe))
                {
                    int stack = robe.Clone().stack;
                    robe.SetDefaults(ModContent.ItemType<WhiteRobe>());
                    robe.stack = stack;
                }

                if (recipe.TryGetIngredient(ItemID.Silk, out Item silk))
                {
                    int stack = silk.Clone().stack;
                    silk.SetDefaults(ModContent.ItemType<WhiteSilk>());
                    silk.stack = stack;
                }
            }

            ItemID.Sets.Deprecated[ItemID.PinkThread] = true;
            ItemID.Sets.Deprecated[ItemID.BlackThread] = true;
            ItemID.Sets.Deprecated[ItemID.GreenThread] = true;
            ItemID.Sets.Deprecated[ItemID.Robe] = true;
            ItemID.Sets.Deprecated[ItemID.Silk] = true;
        }
    }
}
