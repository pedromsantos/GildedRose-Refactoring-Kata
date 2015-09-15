namespace GildedRose
{
    public class Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; private set; }

        public int SellIn { get; private set; }

        public int Quality { get; private set; }

        public bool IsBelowMaximumQuality()
        {
            return Quality < MaximumQuality;
        }

        private const int MaximumQuality = 50;

        private const int MinimumQuality = 0;

        public void SetQuantityToZero()
        {
            Quality = MinimumQuality;
        }

        public bool IsAboveMinimumQuaility()
        {
            return Quality > MinimumQuality;
        }

        public int ChangeSellIn()
        {
            return SellIn = SellIn - 1;
        }

        public bool HasPastSellByDay()
        {
            return SellIn < 0;
        }

        public void IncreaseQualityWhileBelowMaximumQuality()
        {
            if (IsBelowMaximumQuality())
            {
                IncreaseQualiltyByOne();
            }
        }

        public void IncreaseQualiltyByOne()
        {
            Quality++;
        }

        public void DecreaseQualiltyByOne()
        {
            Quality--;
        }
    }
}