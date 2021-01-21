using NCRRanger;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NCRRanger.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class NCRBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Elite Roit Boots");
            Tooltip.SetDefault("Dust from a foreign desert cake the treads\n10% increased ranged critical strike chance\n15% increaced movement speed");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 40000;
            item.rare = ItemRarityID.LightPurple;
            item.defense = 15;
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 10;
            player.moveSpeed += 0.15f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 12);
            recipe.AddIngredient(ItemID.Leather, 5);
            recipe.AddIngredient(ItemID.SandBlock, 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}