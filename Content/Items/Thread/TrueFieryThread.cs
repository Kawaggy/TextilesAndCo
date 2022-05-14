using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace TextilesAndCo.Content.Items.Thread
{
    public class TrueFieryThread : ModItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
        }

        public override string Texture => "TextilesAndCo/Content/Items/Thread/FieryThread";

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1998;
            Item.master = true;
            Item.width = 28;
            Item.height = 20;
            Item.value = Item.buyPrice(gold: 1, silver: 25);
        }

        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            spriteBatch.Draw(ModContent.Request<Texture2D>("TextilesAndCo/Content/Items/Thread/Thread").Value, position, frame, new Color(255, (byte)(Main.masterColor * 200f), 0), 0f, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(ModContent.Request<Texture2D>("TextilesAndCo/Content/Items/Thread/Thread_Wood").Value, position, frame, itemColor, 0f, Vector2.Zero, scale, SpriteEffects.None, 0);
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = ModContent.Request<Texture2D>("TextilesAndCo/Content/Items/Thread/Thread").Value;
            Vector2 offset = new(Item.width / 2 - texture.Width / 2, Item.height - texture.Height);
            Vector2 origin = texture.Size() / 2f;
            spriteBatch.Draw(texture, Item.position - Main.screenPosition + origin + offset, null, new Color(255, (byte)(Main.masterColor * 200f), 0), rotation, origin, scale, SpriteEffects.None, 0f);
            texture = ModContent.Request<Texture2D>("TextilesAndCo/Content/Items/Thread/Thread_Wood").Value;
            spriteBatch.Draw(texture, Item.position - Main.screenPosition + origin + offset, null, lightColor, rotation, origin, scale, SpriteEffects.None, 0f);
        }
    }
}
