using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using static Humanizer.On;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace testingyharim.content.items.armour.yharimarmour
{
    [AutoloadEquip(EquipType.Legs)]
    internal class yharimleggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's leggings");
            Tooltip.SetDefault("15% increased damage, 15% increased critical chance and melee speed.\nIncreased max life and mana by 100");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Purple;

            Item.defense = 150;

        }

        public override void UpdateEquip(Player player)
        {
            //improve health and mana
            player.statLifeMax2 += 100;
            player.statManaMax2 += 100;
            //increase movement speed
            player.moveSpeed += 0.07f;
            //increase damage 
            player.GetDamage<GenericDamageClass>() += 0.15f;
            player.GetCritChance<GenericDamageClass>() += 0.15f;
            player.GetAttackSpeed<GenericDamageClass>() += 0.15f;
            player.thorns += 150f;

        }


    }

}
