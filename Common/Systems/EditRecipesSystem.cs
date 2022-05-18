using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TextilesAndCo.Core.IDs;

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
                .AddIngredient(RobeID.Blue)
                .AddIngredient(SilkID.Red)
                .AddIngredient(ThreadID.White, 12)
                .AddIngredient(ThreadID.Red, 16)
                .AddTile(TileID.Loom)
                .Register();

            //Badger's Hat

            Mod.CreateRecipe(ItemID.BallaHat)
                .AddIngredient(SilkID.Brown, 4)
                .AddIngredient(SilkID.White)
                .AddIngredient(ThreadID.Brown, 5)
                .AddIngredient(ThreadID.White, 3)
                .AddTile(TileID.Loom)
                .Register();

            Mod.CreateRecipe(ItemID.Beanie)
                .AddIngredient(SilkID.White, 4)
                .AddIngredient(ThreadID.White, 3)
                .AddTile(TileID.Loom)
                .Register();

            Mod.CreateRecipe(ItemID.BunnyHood)
                .AddIngredient(SilkID.White, 4)
                .AddIngredient(YarnID.Black, 4)
                .AddIngredient(YarnID.Pink)
                .AddIngredient(ThreadID.White, 3)
                .AddTile(TileID.Loom)
                .Register();

            Mod.CreateRecipe(ItemID.BunnyHood)
                .AddIngredient(SilkID.White, 4)
                .AddIngredient(YarnID.Black, 4)
                .AddIngredient(YarnID.Pink)
                .AddIngredient(ThreadID.White, 3)
                .AddTile(TileID.Loom)
                .Register();

            Mod.CreateRecipe(ItemID.CatEars)
                .AddIngredient(PlasticID.Black, 4)
                .AddTile(TileID.Furnaces)
                .Register();

            Mod.CreateRecipe(ItemID.DeadMansSweater)
               .AddIngredient(SilkID.Red, 7)
               .AddIngredient(ThreadID.Red, 7)
               .AddTile(TileID.SharpeningStation)
               .Register();

            Mod.CreateRecipe(ItemID.DemonHorns)
                .AddIngredient(PlasticID.Red, 8)
                .AddTile(TileID.Furnaces)
                .Register();

            Mod.CreateRecipe(ItemID.DevilHorns)
                .AddIngredient(PlasticID.Red, 2)
                .AddTile(TileID.Furnaces)
                .Register();

            Mod.CreateRecipe(ItemID.DjinnsCurse)
                .AddIngredient(PlasticID.Yellow, 2)
                .AddIngredient(ItemID.SoulofNight, 8)
                .AddTile(TileID.AdamantiteForge)
                .Register();

            Mod.CreateRecipe(ItemID.EngineeringHelmet)
                .AddIngredient(PlasticID.Orange, 8)
                .AddIngredient(PlasticID.Black)
                .AddTile(TileID.Furnaces)
                .Register();

            Mod.CreateRecipe(ItemID.EyePatch)
                .AddIngredient(SilkID.Black, 2)
                .AddIngredient(ThreadID.Black, 6)
                .AddTile(TileID.Loom)
                .Register();

            //eye brella?

            Mod.CreateRecipe(ItemID.Fedora)
                .AddIngredient(SilkID.White, 5)
                .AddIngredient(ThreadID.White, 8)
                .AddTile(TileID.Loom)
                .Register();

            Mod.CreateRecipe(ItemID.Fez)
                .AddIngredient(SilkID.Red, 4)
                .AddIngredient(ThreadID.Red, 3)
                .AddIngredient(YarnID.Yellow, 2)
                .AddTile(TileID.Loom)
                .Register();

            Mod.CreateRecipe(ItemID.GangstaHat)
                .AddIngredient(SilkID.Black, 6)
                .AddIngredient(SilkID.White)
                .AddIngredient(ThreadID.Black, 5)
                .AddIngredient(ThreadID.White, 2)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
