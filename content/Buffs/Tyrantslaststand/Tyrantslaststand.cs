using Terraria;
using Terraria.ModLoader;

namespace testingyharim.content.Buffs.Tyrantslaststand
{
    public class Tyrantslaststand : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's Last Stand");
            Description.SetDefault("wip");
        }

        public override void Update(Player player, ref int buffIndex)
        {

            player.statLifeMax += 1000;
            player.GetDamage(DamageClass.Generic) += 4.0f;
            player.statDefense += 200;
            player.SetImmuneTimeForAllTypes(5400);
           








        }
       
        
    }
}
