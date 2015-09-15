using System.Collections.Generic;

namespace GildedRose
{
    class GildedRose
    {
        public void UpdateQuality(IList<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.IsAboveMinimumQuaility())
                    {
                        if (item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            item.DecreaseQualiltyByOne();
                        }
                    }
                }
                else
                {
                    item.IncreaseQualityWhileBelowMaximumQuality();

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.SellIn < 11)
                        {
                            item.IncreaseQualityWhileBelowMaximumQuality();
                        }

                        if (item.SellIn < 6)
                        {
                            item.IncreaseQualityWhileBelowMaximumQuality();
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.ChangeSellIn();
                }

                if (item.HasPastSellByDay())
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.IsAboveMinimumQuaility())
                            {
                                if (item.Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    item.DecreaseQualiltyByOne();
                                }
                            }
                        }
                        else
                        {
                            item.SetQuantityToZero();
                        }
                    }
                    else
                    {
                        if (item.IsBelowMaximumQuality())
                        {
                            item.IncreaseQualiltyByOne();
                        }
                    }
                }
            }
        }
    }
}
