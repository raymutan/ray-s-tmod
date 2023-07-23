using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using testingyharim.content.items.projectile;
using testingyharim.content.items.projectile.flamesword;

namespace testingyharim.content.items.weapons
{
    

    internal class Yharimsword : ModItem
    {
        


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("God Slayer Blade WIP");
            Tooltip.SetDefault("Still WIP gotta wait");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults() //default stats
        {
            //hitbox
            Item.width = 300;
            Item.height = 300;
            //use and animation style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 60;
            Item.useAnimation = 30;
            Item.autoReuse = false;
            //Damage Values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 3000;
            Item.knockBack = 3.5f;
            Item.crit = 40;

            //Misc
            Item.value = Item.buyPrice(silver: 88);
            Item.rare = ItemRarityID.Purple;


            //Sound
            Item.UseSound = SoundID.Item1;
           
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;

        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                
                //hitbox
                Item.width = 1000;
                Item.height = 1000;
                //use and animation style
                Item.useStyle = ItemUseStyleID.Thrust;
                Item.useTime = 600;
                Item.useAnimation = 30;
                Item.autoReuse = false;
                //Damage Values
                Item.DamageType = DamageClass.Melee;
                Item.damage = 6000;
                Item.knockBack = 3.5f;
                Item.crit = 100;

                //Misc
                Item.value = Item.buyPrice(silver: 88);
                Item.rare = ItemRarityID.Purple;


                //Sound
                Item.UseSound = SoundID.Item1;
                //projectile WIP
                Item.shoot = ModContent.ProjectileType<flamesword>();
                Item.shootSpeed = 10;

            }
            else
            {
                //hitbox
                Item.width = 300;
                Item.height = 300;
                //use and animation style
                Item.useStyle = ItemUseStyleID.Swing;
                Item.useTime = 120;
                Item.useAnimation = 30;
                Item.autoReuse = false;
                //Damage Values
                Item.DamageType = DamageClass.Melee;
                Item.damage = 3000;
                Item.knockBack = 3.5f;
                Item.crit = 40;
                //Misc
                Item.value = Item.buyPrice(silver: 88);
                Item.rare = ItemRarityID.Purple;


                //Sound
                Item.UseSound = SoundID.Item1;


            }
            return true;

;

        }



        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<tutorialitem>(), 8)// Addingredient takes ItemID, then quantity
                .AddTile(TileID.Anvils)// Addtile takes the TileID
                .Register();
           
         }

        
    }
}
