using System;

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

    public virtual void DecrementQuality()
    {
        if (Name == "Backstage passes to a TAFKAL80ETC concert"
            && SellIn < 0)
            Quality = 0;

        Quality = Math.Max(0, Quality - 1);
    }

    public void IncrementQuality()
    {
        Quality = Math.Min(MaxItemQuality, Quality + 1);
    }
    
    public virtual void DecrementSellIn()
    {
        SellIn -= 1;
    }
}