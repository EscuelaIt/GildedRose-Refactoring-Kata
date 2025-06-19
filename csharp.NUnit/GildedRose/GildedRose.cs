using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    const int MaxItemQuality = 50;
    
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            UpdateQualityOfItemByIndex(i);
        }
    }

    void UpdateQualityOfItemByIndex(int i)
    {
        aklsjdflkadjf(i);
        DecreaseSellInByOneIfNotSulfuras(i);
        kdjfkajsd(i);
    }

    void kdjfkajsd(int i)
    {
        if (Items[i].SellIn < 0)
        {
            if (Items[i].Name != "Aged Brie")
            {
                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality -= 1;
                        }
                    }
                }
                else
                {
                    Items[i].Quality -= Items[i].Quality;
                }
            }
            else
            {
                if (Items[i].Quality < MaxItemQuality)
                {
                    Items[i].Quality += 1;
                }
            }
        }
    }

    void DecreaseSellInByOneIfNotSulfuras(int i)
    {
        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        {
            Items[i].SellIn -= 1;
        }
    }

    void aklsjdflkadjf(int i)
    {
        if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        {
            DecrementQualityByOneIfNotSulfuras(i);
        }
        else
        {
            jkjfaklsd(i);
        }
    }

    void jkjfaklsd(int i)
    {
        if (Items[i].Quality < MaxItemQuality)
        {
            Items[i].Quality += 1;

            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[i].SellIn < 11)
                {
                    if (Items[i].Quality < MaxItemQuality)
                    {
                        Items[i].Quality += 1;
                    }
                }

                if (Items[i].SellIn < 6)
                {
                    if (Items[i].Quality < MaxItemQuality)
                    {
                        Items[i].Quality += 1;
                    }
                }
            }
        }
    }

    void DecrementQualityByOneIfNotSulfuras(int i)
    {
        if (Items[i].Quality > 0)
        {
            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].Quality -= 1;
            }
        }
    }
}