
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace testingyharim.content.items.accessories
{
    internal class Soulofthetyrant : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant's soul WIP");
            Tooltip.SetDefault(" Be blessed by the tyrant,Yharim himself.\nIncrease all damage by 10%\nGain an increased 20% critical chance\nReceive a bonus 30% armor penetration\nTyrant's last stand ");
            //This access the creative catalog
            //setting the research number to 100 before it can be fully accessed
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;

            Item.accessory = true;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Purple;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.10f; //increase all damage by 25%
            player.GetCritChance(DamageClass.Generic) += 20f;
            player.GetArmorPenetration(DamageClass.Generic) += 30f;

        }
    }
}
