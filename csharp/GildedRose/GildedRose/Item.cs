namespace GildedRose
{
    public class Item
    {
        private const int MinimumQualityThresold = 0;

        private const int MaximumQualityThresold = 50;

        private const int DefaultQualityUpdate = 1;

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public void IncreaseItemQuality(int qualityIncrease = DefaultQualityUpdate)
        {
            Quality = Quality + qualityIncrease;

            if (Quality > MaximumQualityThresold)
            {
                Quality = MaximumQualityThresold;
            }
        }

        public void DecreaseItemQuality(int qualityIncrease = DefaultQualityUpdate)
        {
            if (Name != "Sulfuras, Hand of Ragnaros")
            {
                Quality = Quality - qualityIncrease;

                if (Quality < MinimumQualityThresold)
                {
                    Quality = MinimumQualityThresold;
                }
            }
        }
    }
}