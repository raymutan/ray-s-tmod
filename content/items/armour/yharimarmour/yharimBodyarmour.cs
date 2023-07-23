using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;



namespace testingyharim.content.items.armour.yharimarmour
{
    [AutoloadEquip(EquipType.Body)]
    internal class yharimBodyarmour: ModItem

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's Breastplate");
            Tooltip.SetDefault("50% increased damage,25% increased critical chance and melee speed.\nIncreased max life and mana by 150\nEnemies receive an unholy amount of damage when touching you");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Purple;

            Item.defense = 200;
            
        }

        public override void UpdateEquip(Player player)
        {      
            //improve health and mana
            player.statLifeMax2 += 100;
            player.statManaMax2 += 100;
            //increase movement speed
            player.moveSpeed += 0.07f;
            //increase damage 
            player.GetDamage<GenericDamageClass>() += 0.50f;
            player.GetCritChance<GenericDamageClass>() += 0.15f;
            player.GetAttackSpeed<GenericDamageClass>() += 0.15f;
            player.thorns += 150f;

        }
    }
}
