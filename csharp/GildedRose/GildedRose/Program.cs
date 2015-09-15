using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item>{
				new Item ("+5 Dexterity Vest", 10, 20),
				new Item ("Aged Brie", 2, 0),
				new Item ("Elixir of the Mongoose", 5, 7),
				new Item ("Sulfuras, Hand of Ragnaros", 0, 80),
				new Item ("Sulfuras, Hand of Ragnaros", -1, 80),
				new Item
				(
					"Backstage passes to a TAFKAL80ETC concert",
					15,
					20
				),
				new Item
				(
					"Backstage passes to a TAFKAL80ETC concert",
					10,
					49
				),
				new Item
				(
					"Backstage passes to a TAFKAL80ETC concert",
					5,
					49
				),
				// this conjured item does not work properly yet
				new Item ("Conjured Mana Cake", 3, 6)
			};

            var app = new GildedRose();


            for (var i = 0; i < 31; i++)
            {
                System.Console.WriteLine("-------- day " + i + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    System.Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
                System.Console.WriteLine("");
                app.UpdateQuality(items);
            }

        }

    }
}
