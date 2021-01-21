using NCRRanger;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NCRRanger.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class NCRHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Elite Roit Helmet");
            Tooltip.SetDefault("Many of the features on this unit appear broken, but the eyes still shine bright\n18% increased ranged damage\n20% increased ranged critical strike chance\nCharisma +1\nGrants Sneak Sight");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 55000;
            item.rare = ItemRarityID.LightPurple;
            item.defense = 12;
        }
        public override void UpdateEquip(Player player)
        {
            player.AddBuff(mod.BuffType("SneakSight"), 2);
            player.rangedDamage += 0.18f;
            player.rangedCrit += 20;
            player.maxMinions ++;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("NCRGear") && legs.type == mod.ItemType("NCRBoots");
        }
        public override void UpdateArmorSet(Player player)
        {
            string NCRSetBonus = ("Red Scare\nHighlights enemies and improves night vision\n20% increased ranged critical strike chance");
            player.setBonus = NCRSetBonus;
            player.AddBuff(mod.BuffType("RedScare"), 2);
            player.rangedDamage += 0.2f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddIngredient(ItemID.Ruby, 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}