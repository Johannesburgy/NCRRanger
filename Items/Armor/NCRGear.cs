using NCRRanger;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NCRRanger.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class NCRGear : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Elite Roit Gear");
            Tooltip.SetDefault("'LAPD RIOT' stands proudly, yet heavily weathered on the chestpiece\n10% increased damage\n15% increased ranged critical strike chance\nGrants Endurance");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = ItemRarityID.LightPurple;
            item.defense = 25;
        }
        public override void UpdateEquip(Player player)
        {
            player.endurance += 1f;
            player.rangedDamage += 0.1f;
            player.meleeDamage += 0.1f;
            player.magicDamage += 0.1f;
            player.minionDamage += 0.1f;
            player.rangedCrit += 15;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(ItemID.AncientCloth, 2);
            recipe.AddIngredient(ItemID.HighVelocityBullet, 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}