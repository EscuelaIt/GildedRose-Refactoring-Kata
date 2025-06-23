using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    const int MaxItemQuality = 50;
    const int SomethingLikeThresholdOfBackstagePassesSellIn = 11;
    
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }
    
    public void EndDay()
    {
        foreach (var item in Items)
        {
            EndDayOf(item);
        }
    }
    
    void EndDayOf(Item item)
    {
        var timePassage = new TimePassage(item, MaxItemQuality);
        timePassage.PassOneDay();
    }
}