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
    
    //Refactor 1, smell: obsesión por primitivos en parámetro i.
    void UpdateQualityOfItemByIndex(int i)
    {
        aklsjdflkadjf(i);
        DecreaseSellInByOneIfNotSulfuras(i);
        kdjfkajsd(i);
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void kdjfkajsd(int i)
    {
        if (Items[i].SellIn < 0)
        {
            if (Items[i].Name != "Aged Brie")
            {
                //Refactor2, smell: aquí hay un ejemplo de string hardcodeada.
                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    //Refactor 4: smell código duplicado de algo que ya se extrajo parcialmente
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

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void DecreaseSellInByOneIfNotSulfuras(int i)
    {
        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        {
            Items[i].SellIn -= 1;
        }
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
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

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
    void jkjfaklsd(int i)
    {
        if (Items[i].Quality < MaxItemQuality)
        {
            Items[i].Quality += 1;

            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                //Refactor 2: ¿es esto un smell? ¿Es cirugía a escopetazos?
                if (Items[i].SellIn < 11)
                {
                    //Refactor 3: smell códido duplicado (esta es la primera vez)
                    if (Items[i].Quality < MaxItemQuality)
                    {
                        Items[i].Quality += 1;
                    }
                }

                //Refactor 2: ¿es esto un smell? ¿Es cirugía a escopetazos?
                if (Items[i].SellIn < 6)
                {
                    //Refactor 3: smell códido duplicado (esta es la segunda vez)
                    if (Items[i].Quality < MaxItemQuality)
                    {
                        Items[i].Quality += 1;
                    }
                }
            }
        }
    }

    //Refactor 1: smell: obsesión por primitivos en parámetro i.
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