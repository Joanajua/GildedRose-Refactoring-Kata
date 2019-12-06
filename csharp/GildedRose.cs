using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace csharp
{
    public class GildedRose
    {
        
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            var sulfuras = "Sulfuras, Hand of Ragnaros";
            var agedBrie = "Aged Brie";
            var passes = "Backstage passes to a TAFKAL80ETC concert";

            var i = 0;
            string name = Items[i].Name;
            int quality = Items[i].Quality;
            int sellIn = Items[i].SellIn;



            for ( i = 0; i < Items.Count; i++)
            {
                

                if (name != agedBrie && name != passes)
                {
                    if (quality > 0 && name != sulfuras)
                    {
                            quality -= quality;
                    }
                }
                else
                {
                    if (quality < 50 && name == passes)
                    {
       
                        if (sellIn < 11)
                        {
                            quality = quality + 3;
                        }
                        if (sellIn < 6)
                        {
                            quality = quality + 2;
                        }
                        else
                        {
                            quality += quality;
                        }
                    }
                }

                if (name != sulfuras)
                {
                    sellIn -= sellIn;
                }

                if (sellIn < 0)
                {
                    if (name != agedBrie && name != passes)
                    {

                        if (quality > 0 && name != sulfuras)
                        {
                            quality -= quality;
                        }
                        else
                        {
                            quality = 0;
                        }
                    }
                    else
                    {
                        if (quality < 50)
                        {
                            quality += quality;
                        }
                    }
                }
            }

        }
        

    }
}


   

