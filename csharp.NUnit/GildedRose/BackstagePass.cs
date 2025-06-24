namespace GildedRoseKata;

public class BackstagePass : Item
{
    BackstagePass(int sellIn, int quality)
    {
        Name = "Backstage passes to a TAFKAL80ETC concert";
        SellIn = sellIn;
        Quality = quality;
    }

    internal static BackstagePass With(int sellIn, int quality)
    {
        return new BackstagePass(sellIn, quality);
    }

    public override void DecrementQuality()
    {
        IncrementQuality();
        if( SellIn <= 10)
            IncrementQuality();
        if( SellIn <= 5)
            IncrementQuality();
        if (SellIn < 0)
            Quality = 0;
    }
}