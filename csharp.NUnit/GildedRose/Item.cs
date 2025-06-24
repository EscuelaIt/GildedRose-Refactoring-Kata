namespace GildedRoseKata;

public class Item
{
    internal const int MaxItemQuality = 50;

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void PassDay()
    {
        
    }

    public void DecrementQuality()
    {
        if (Name == "Backstage passes to a TAFKAL80ETC concert"
            && SellIn < 0)
            Quality = 0;

        if (Name == "Aged Brie" && SellIn < 0)
        {
            IncrementQuality();
            return;
        }
            
        
        if (Quality <= 0)
            return;
        
        if (Name == "Sulfuras, Hand of Ragnaros")
            return;
        
        Quality -= 1;
    }

    public void IncrementQuality()
    {
        if (Quality < MaxItemQuality)
            Quality += 1;
    }
    
    public void DecrementSellIn()
    {
        if (Name != "Sulfuras, Hand of Ragnaros")
            SellIn -= 1;
    }
}