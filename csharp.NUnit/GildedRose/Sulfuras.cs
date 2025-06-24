namespace GildedRoseKata;

public class Sulfuras : Item
{
    Sulfuras(int sellIn, int quality)
    {
        Name = "Sulfuras, Hand of Ragnaros";
        SellIn = sellIn;
        Quality = quality;
    }

    public static Sulfuras With(int sellIn, int quality)
    {
        return new Sulfuras(sellIn, quality);
    }

    public override void DecrementQuality()
    {
        //Sulfuras is legendary and does not decrease in quality.
    }

    public override void DecrementSellIn()
    {
        //Sulfuras is legendary and does not decrease in sellIn.
    }
}