using System.Collections.Generic;

namespace GildedRose
{
    class GildedRose
    {
        private readonly IEnumerable<Item> items;

        public GildedRose(IEnumerable<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.DecreaseItemQuality();
                }
                else
                {
                    var increaseQualityBy = 1;

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.SellIn < 11)
                        {
                            increaseQualityBy++;
                        }

                        if (item.SellIn < 6)
                        {
                            increaseQualityBy++;
                        }
                    }

                    item.IncreaseItemQuality(increaseQualityBy);
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            item.DecreaseItemQuality();
                        }
                        else
                        {
                            item.DecreaseItemQuality(item.Quality);
                        }
                    }
                    else
                    {
                        item.IncreaseItemQuality();
                    }
                }
            }
        }
    }
}
