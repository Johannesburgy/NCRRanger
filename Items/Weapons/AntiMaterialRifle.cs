using Microsoft.Xna.Framework;
using NCRRanger;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NCRRanger.Items.Weapons
{
    public class AntiMaterialRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Anti-Material Rifle");
            Tooltip.SetDefault("'The last thing they never saw'\nFires a .50MG round\nRight click to zoom");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.useAnimation = 36;
            item.useTime = 36;
            item.autoReuse = true;
            item.crit = 30;
            item.width = 44;
            item.height = 14;
            item.shoot = 10;
            item.UseSound = SoundID.Item40;
            item.useAmmo = AmmoID.Bullet;
            item.damage = 255;
            item.shootSpeed = 50f;
            item.noMelee = true;
            item.value = 1800000;
            item.knockBack = 10f;
            item.rare = ItemRarityID.Yellow;
            item.ranged = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SniperRifle, 1);
            recipe.AddIngredient(ItemID.SniperScope, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void HoldItem(Player player)
        {
            player.scope = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ProjectileID.BulletHighVelocity;
            }
            return true;
        }
    }
}