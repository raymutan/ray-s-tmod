using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using testingyharim.content.items.projectile.bluesoul;
using testingyharim.content.items.projectile.greensoul;
using testingyharim.content.items.projectile.purplesoul;
using testingyharim.content.items.projectile.redsoul;
using testingyharim.content.items.projectile.yellowsoul;
using testingyharim.content.items.weapons.Soulofunityitem;
using testingyharim.content.items.projectile.Soulofunity;

namespace testingyharim.content.Buffs.SoulofunityBuff
{
    public class SoulofunityBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Unity");
            Description.SetDefault("wip");
        }

        public override void Update(Player player, ref int buffIndex)
        {


            if (player.ownedProjectileCounts[ModContent.ProjectileType<Soulofunity>()] > 0)

            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }

            //red soul buff
            player.GetDamage(DamageClass.Generic) += 0.2f;
            player.GetCritChance(DamageClass.Generic) += 0.10f;

            //blue soul buff
            player.moveSpeed += 0.15f;
            player.GetAttackSpeed<GenericDamageClass>() += 0.25f;

            //green soul buff
            player.lifeRegen = 50;
            player.statLifeMax2 += 50;

            //yellow soul buff
            player.AddBuff(BuffID.Endurance, 7200);
            player.AddBuff(BuffID.Ironskin, 7200);

            //purple soul buff
            player.lifeSteal += 10;
             
            





        }


    }
}
