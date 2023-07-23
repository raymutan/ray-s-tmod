using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using static Humanizer.On;
using System.Diagnostics.Metrics;
using System.Threading.Channels;


namespace testingyharim.content.items.armour.yharimarmour
{
    [AutoloadEquip(EquipType.Head)]
    internal class yharimhelmet :ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's Armor");
            Tooltip.SetDefault("25 % increased damage, 25 % increased critical chance and melee speed.\nIncreased max life and mana by 150\nEnemies receive an unholy amount of damage when touching you");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;//dont draw head

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
            player.GetDamage<GenericDamageClass>() += 0.25f;
            player.GetCritChance<GenericDamageClass>() += 0.25f;
            player.GetAttackSpeed<GenericDamageClass>() += 0.25f;
            player.thorns += 150f;

        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<yharimBodyarmour>();
            bool legsMatch = legs.type == ModContent.ItemType<yharimleggings>();
            return bodyMatch && legsMatch;
        }

        public override void UpdateArmorSet(Player player)


        {
            player.setBonus = Language.GetTextValue("Mods.testingyharim.ItemSetBonus.yharimset");

            //buffs
            player.lifeRegen += 200;
            player.lifeSteal += 20;
            player.noKnockback = true;
            //health and mana
            player.statDefense += 1000;
            player.statLifeMax2 += 1000;
            //damage buff
            player.GetDamage<GenericDamageClass>() += 0.50f;
            player.GetCritChance<GenericDamageClass>() += 0.25f;
            player.GetAttackSpeed<GenericDamageClass>() += 0.25f;
             

        }
    }
}
