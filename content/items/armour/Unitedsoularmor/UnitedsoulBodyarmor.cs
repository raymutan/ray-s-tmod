using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using testingyharim.content.items.projectile.purplesoul;
using testingyharim.content.items.projectile.redsoul;
using testingyharim.content.items.projectile.yellowsoul;
using testingyharim.content.items.projectile.Soulofunity;
using testingyharim.content.Buffs.SoulofunityBuff;

namespace testingyharim.content.items.armour.Unitedsoularmor
{
    [AutoloadEquip(EquipType.Body)]
    internal class UnitedsoulBodyarmor : ModItem

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("United Souls Chestplate");
            Tooltip.SetDefault("Harness the true potential of the souls of fury,malice and warding");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Purple;

            Item.defense = 50;
            
        }

        public override void UpdateEquip(Player player)
        {
            //improve health and mana
            player.statLifeMax2 += 50;
            player.statManaMax2 += 50;
            //red soul
            player.GetCritChance<GenericDamageClass>() += 0.15f;
            player.GetAttackSpeed<GenericDamageClass>() += 0.15f;
            //purplesoul
            player.lifeSteal += 20;
            player.slotsMinions += 5;
            
            


        }

    }
}

