using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using testingyharim.content.Buffs.Tyrantslaststand;
using testingyharim.content.Buffs;


namespace testingyharim.content.items.potions.Tyrantslaststandpotion
{
    public class Tyrantslaststandpotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's Blood");
            Tooltip.SetDefault("WIP for testing only.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;

            // Dust that will appear in these colors when the item with ItemUseStyleID.DrinkLiquid is used
            ItemID.Sets.DrinkParticleColors[Type] = new Color[3] {
                new Color(240, 240, 240),
                new Color(200, 200, 200),
                new Color(140, 140, 140)
            };
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.buyPrice(gold: 1);
            Item.buffType = ModContent.BuffType<Tyrantslaststand>();
            Item.buffTime = 5400; // The amount of tim the buff declared in Item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.

            
        }
       
    }
}