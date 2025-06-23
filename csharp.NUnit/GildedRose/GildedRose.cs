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

    // Refactor 6: smell leaked abstraction (en este caso semántica)
    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            UpdateQualityOf(item);
        }
    }
    
    //Refactor 1, smell: obsesión por primitivos en parámetro i.
    void UpdateQualityOf(Item item)
    {
        //Refactor 7: extract class!
        aklsjdflkadjf(item);
        DecreaseSellInByOneIfNotSulfuras(item);
        kdjfkajsd(item);
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void kdjfkajsd(Item item)
    {
        if (item.SellIn < 0)
        {
            if (item.Name != "Aged Brie")
            {
                //Refactor2, smell: aquí hay un ejemplo de string hardcodeada.
                if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    //Refactor 4: smell código duplicado de algo que ya se extrajo parcialmente
                    if (item.Quality > 0)
                    {
                        if (item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            item.Quality -= 1;
                        }
                    }
                }
                else
                {
                    item.Quality -= item.Quality;
                }
            }
            else
            {
                if (item.Quality < MaxItemQuality)
                {
                    item.Quality += 1;
                }
            }
        }
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void DecreaseSellInByOneIfNotSulfuras(Item item)
    {
        if (item.Name != "Sulfuras, Hand of Ragnaros")
        {
            item.SellIn -= 1;
        }
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void aklsjdflkadjf(Item item)
    {
        if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
        {
            DecrementQualityByOneIfNotSulfuras(item);
        }
        else
        {
            jkjfaklsd(item);
        }
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void jkjfaklsd(Item item)
    {
        if (item.Quality < MaxItemQuality)
        {
            item.Quality += 1;

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn < SomethingLikeThresholdOfBackstagePassesSellIn)
                {
                    //Refactor 3: smell códido duplicado (esta es la primera vez)
                    if (item.Quality < MaxItemQuality)
                    {
                        item.Quality += 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    IncreaseQualityByOne(item);
                }
            }
        }
    }

    static void IncreaseQualityByOne(Item item)
    {
        if (item.Quality < MaxItemQuality)
        {
            item.Quality += 1;
        }
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void DecrementQualityByOneIfNotSulfuras(Item item)
    {
        if (item.Quality > 0)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality -= 1;
            }
        }
    }
}