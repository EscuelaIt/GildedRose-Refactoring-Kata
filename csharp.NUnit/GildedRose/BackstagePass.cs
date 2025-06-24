namespace GildedRoseKata;

public class BackstagePass : Item
{
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