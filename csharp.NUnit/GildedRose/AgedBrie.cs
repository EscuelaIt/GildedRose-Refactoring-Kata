namespace GildedRoseKata;

public class AgedBrie : Item
{
    AgedBrie(int sellIn, int quality)
    {
        Name = "Aged Brie";
        SellIn = sellIn;
        Quality = quality;
    }
    public static AgedBrie With(int sellIn, int quality)
    {
        return new AgedBrie(sellIn, quality);
    }
    
    public override void DecrementQuality()
    {
        if (SellIn < 0)
            IncrementQuality();
    }
}