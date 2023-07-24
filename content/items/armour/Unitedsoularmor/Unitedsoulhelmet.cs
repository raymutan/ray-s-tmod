using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.Localization;

using static Humanizer.On;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using testingyharim.content.items.armour;
using testingyharim.content.items.projectile.redsoul;
using testingyharim.content.Buffs.SoulofunityBuff;
using Mono.Cecil;
using testingyharim.content.items.projectile.Soulofunity;
using testingyharim.content.items.weapons.Soulofunityitem;
using testingyharim.content.items.projectile.bluesoul;
using testingyharim.content.items.projectile.greensoul;
using testingyharim.content.items.projectile.yellowsoul;
using testingyharim.content.items.projectile.purplesoul;

namespace testingyharim.content.items.armour.Unitedsoularmor
{
    [AutoloadEquip(EquipType.Head)]
    internal class Unitedsoulhelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's Armor");
            Tooltip.SetDefault("25 % increased damage, 25 % increased critical chance and melee speed.\nIncreased max life and mana by 150\nEnemies receive an unholy amount of damage when touching you");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;

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
            player.maxMinions += 20;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<UnitedsoulBodyarmor>();
            bool legsMatch = legs.type == ModContent.ItemType<Unitedsoulleggings>();
            return bodyMatch && legsMatch;
        }

        public override void UpdateArmorSet(Player player)


        {
            player.setBonus = Language.GetTextValue("Mods.testingyharim.ItemSetBonus.yharimset");
            if (player.FindBuffIndex(ModContent.BuffType<SoulofunityBuff>()) == -1)
            {
                player.AddBuff(ModContent.BuffType<SoulofunityBuff>(), 3600, true, false);
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<Soulofunity>()] < 1)//soul of unity damage and summon
            {
                int baseDamage = 200;
                int damage = (int)player.GetTotalDamage<SummonDamageClass>().ApplyTo(10000f);
                Projectile.NewProjectileDirect(player.GetSource_FromThis("Soulofunity_unitedsoularmor"), player.Center, new Microsoft.Xna.Framework.Vector2(0, -Main.rand.NextFloat(2f, 4f)).RotatedByRandom(0.3f), ModContent.ProjectileType<Soulofunity>(), damage, 0f, Main.myPlayer, 0f, 0f).originalDamage = baseDamage;
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<RedsoulMinionItem.Redsoul>()] < 1)//Redsoul dps and summon
            {
                int baseDamage = 100;
                int damage = (int)player.GetTotalDamage<SummonDamageClass>().ApplyTo(10000f);
                Projectile.NewProjectileDirect(player.GetSource_FromThis("Soulofunity_unitedsoularmor"), player.Center, new Microsoft.Xna.Framework.Vector2(0, -Main.rand.NextFloat(2f, 4f)).RotatedByRandom(0.3f), ModContent.ProjectileType<RedsoulMinionItem.Redsoul>(), damage, 0f, Main.myPlayer, 0f, 0f).originalDamage = baseDamage;
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<BluesoulItem.Bluesoul>()] < 1)//Yellowsoul dps and summon
            {
                int baseDamage = 100;
                int damage = (int)player.GetTotalDamage<SummonDamageClass>().ApplyTo(10000f);
                Projectile.NewProjectileDirect(player.GetSource_FromThis("Soulofunity_unitedsoularmor"), player.Center, new Microsoft.Xna.Framework.Vector2(0, -Main.rand.NextFloat(2f, 4f)).RotatedByRandom(0.3f), ModContent.ProjectileType<BluesoulItem.Bluesoul>(), damage, 0f, Main.myPlayer, 0f, 0f).originalDamage = baseDamage;
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<GreensoulItem.Greensoul>()] < 1)//Greensoul dps and summon
            {
                int baseDamage = 100;       
                int damage = (int)player.GetTotalDamage<SummonDamageClass>().ApplyTo(10000f);
                Projectile.NewProjectileDirect(player.GetSource_FromThis("Soulofunity_unitedsoularmor"), player.Center, new Microsoft.Xna.Framework.Vector2(0, -Main.rand.NextFloat(2f, 4f)).RotatedByRandom(0.3f), ModContent.ProjectileType<GreensoulItem.Greensoul>(), damage, 0f, Main.myPlayer, 0f, 0f).originalDamage = baseDamage;
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<PurplesoulItem.Purplesoul>()] < 1)//Purplesoul dps and summon
            {   
                int baseDamage = 100;
                int damage = (int)player.GetTotalDamage<SummonDamageClass>().ApplyTo(10000f);
                Projectile.NewProjectileDirect(player.GetSource_FromThis("Soulofunity_unitedsoularmor"), player.Center, new Microsoft.Xna.Framework.Vector2(0, -Main.rand.NextFloat(2f, 4f)).RotatedByRandom(0.3f), ModContent.ProjectileType<PurplesoulItem.Purplesoul>(), damage, 0f, Main.myPlayer, 0f, 0f).originalDamage = baseDamage;
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<YellowsoulItem.Yellowsoul>()] < 1)//Yellowsoul dps and summon
            {
                
                int baseDamage = 100;
                int damage = (int)player.GetTotalDamage<SummonDamageClass>().ApplyTo(10000f);
                Projectile.NewProjectileDirect(player.GetSource_FromThis("Soulofunity_unitedsoularmor"), player.Center, new Microsoft.Xna.Framework.Vector2(0, -Main.rand.NextFloat(2f, 4f)).RotatedByRandom(0.3f), ModContent.ProjectileType<YellowsoulItem.Yellowsoul>(), damage, 0f, Main.myPlayer, 0f, 0f).originalDamage = baseDamage;
            }



        }
    }
}


