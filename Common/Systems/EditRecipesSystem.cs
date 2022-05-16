using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Core;

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
                    int stack = pink.Clone().stack;
                    pink.SetDefaults(ThreadID.Pink);
                    pink.stack = stack;
                }

                if (recipe.TryGetIngredient(ItemID.BlackThread, out Item black))
                {
                    int stack = black.Clone().stack;
                    black.SetDefaults(ThreadID.Black);
                    black.stack = stack;
                }

                if (recipe.TryGetIngredient(ItemID.GreenThread, out Item green))
                {
                    int stack = green.Clone().stack;
                    green.SetDefaults(ThreadID.Green);
                    green.stack = stack;
                }

                if (recipe.TryGetResult(ItemID.GreenThread, out _))
                {
                    recipe.RemoveRecipe();
                }

                if (recipe.TryGetIngredient(ItemID.Robe, out Item robe))
                {
                    int stack = robe.Clone().stack;
                    robe.SetDefaults(RobeID.White);
                    robe.stack = stack;
                }

                if (recipe.TryGetIngredient(ItemID.Silk, out Item silk))
                {
                    int stack = silk.Clone().stack;
                    silk.SetDefaults(SilkID.White);
                    silk.stack = stack;
                }

                if (recipe.TryGetResult(ItemID.Silk, out _))
                {
                    recipe.RemoveRecipe();
                }

                if (recipe.TryGetResult(ItemID.Robe, out _))
                {
                    recipe.RemoveRecipe();
                }
            }

            ItemID.Sets.Deprecated[ItemID.PinkThread] = true;
            ItemID.Sets.Deprecated[ItemID.BlackThread] = true;
            ItemID.Sets.Deprecated[ItemID.GreenThread] = true;
            ItemID.Sets.Deprecated[ItemID.Silk] = true;

            Mod.CreateRecipe(ItemID.Robe)
                .AddIngredient(SilkID.Blue, 7)
                .AddIngredient(ThreadID.White, 12)
                .AddIngredient(SilkID.Red)
                .AddIngredient(ThreadID.Red, 16)
                .Register();
        }
    }
}
