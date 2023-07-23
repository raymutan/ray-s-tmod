using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;


namespace testingyharim.content.items
{
    internal class tutorialitem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("tutorial item");
            Tooltip.SetDefault("this is a tutorial material \n This is line 2 ");
            //This access the creative catalog
            //setting the research number to 100 before it can be fully accessed
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16; //Hitbox width from bottom center
            Item.height = 16; //hitbox heigh from bottom center

            Item.value = Item.buyPrice(copper: 30); //value in-game
            Item.maxStack = 10;
        }

    }
}
