using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace testingyharim.content.items.projectile.flamesword
{
    public class flamesword : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("weeee");
        }
        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 200;
            Projectile.height = 200;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 6;
            Projectile.timeLeft = 300;
            Projectile.light = 1;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;

        }
        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].noGravity = true;
            Main.dust[dust].velocity *= 0.3f;
            Main.dust[dust].scale = (float)Main.rand.Next(115, 135);

            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].velocity *= 0.3f;
            Main.dust[dust2].scale = (float)Main.rand.Next(115, 135);

            int dust3 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust3].noGravity = true;
            Main.dust[dust3].velocity *= 0.3f;
            Main.dust[dust3].scale = (float)Main.rand.Next(115, 135);

            int dust4 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust4].noGravity = true;
            Main.dust[dust4].velocity *= 0.3f;
            Main.dust[dust4].scale = (float)Main.rand.Next(115, 135);

            int dust5 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust5].noGravity = true;
            Main.dust[dust5].velocity *= 0.3f;
            Main.dust[dust5].scale = (float)Main.rand.Next(115, 135);

            int dust6 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust6].noGravity = true;
            Main.dust[dust6].velocity *= 0.3f;
            Main.dust[dust6].scale = (float)Main.rand.Next(115, 135);

            int dust7 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust7].noGravity = true;
            Main.dust[dust7].velocity *= 0.3f;
            Main.dust[dust7].scale = (float)Main.rand.Next(115, 135);

            int dust8 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust8].noGravity = true;
            Main.dust[dust8].velocity *= 0.3f;
            Main.dust[dust8].scale = (float)Main.rand.Next(115, 135);

            int dust9 = Dust.NewDust(Projectile.Bottom, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust9].noGravity = true;
            Main.dust[dust9].velocity *= 0.2f;
            Main.dust[dust9].scale = (float)Main.rand.Next(115, 135);

            int dust10 = Dust.NewDust(Projectile.Bottom, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust10].noGravity = true;
            Main.dust[dust10].velocity *= 0.2f;
            Main.dust[dust10].scale = (float)Main.rand.Next(115, 135);

            int dust11 = Dust.NewDust(Projectile.Top, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust11].noGravity = true;
            Main.dust[dust11].velocity *= 0.2f;
            Main.dust[dust11].scale = (float)Main.rand.Next(115, 135);

            int dust12 = Dust.NewDust(Projectile.Bottom, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust12].noGravity = true;
            Main.dust[dust12].velocity *= 0.2f;
            Main.dust[dust12].scale = (float)Main.rand.Next(115, 135);

            int dust13 = Dust.NewDust(Projectile.Top, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust13].noGravity = true;
            Main.dust[dust13].velocity *= 0.2f;
            Main.dust[dust13].scale = (float)Main.rand.Next(115, 135);

            int dust14 = Dust.NewDust(Projectile.Top, 1, 1, DustID.Lava, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust14].noGravity = true;
            Main.dust[dust14].velocity *= 0.2f;
            Main.dust[dust14].scale = (float)Main.rand.Next(115, 135);


        }




        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire3, 1000 * 60);
            target.AddBuff(BuffID.Weak, 100 * 60);
        }

    }
}    

