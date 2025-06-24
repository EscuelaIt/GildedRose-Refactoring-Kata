using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    const int SomethingLikeThresholdOfBackstagePassesSellIn = 11;
    
    IList<Item> Items;

    TimePassage timePassage = new TimePassage(Item.MaxItemQuality);

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }
    
    public void EndDay()
    {
        foreach (var item in Items)
        {
            timePassage.PassOneDay(item);
            item.PassDay();
        }
    }
}