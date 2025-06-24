namespace GildedRoseKata;

class TimePassage
{
    const int SomethingLikeThresholdOfBackstagePassesSellIn = 11;
    readonly int maxItemQuality;

    public TimePassage(int maxItemQuality)
    {
        this.maxItemQuality = maxItemQuality;
    }

    public void PassOneDay(Item item)
    {
        Process(item);
    }

    void Process(Item item)
    {
        aklsjdflkadjf(item);
        DecreaseSellInByOneIfNotSulfuras(item);
        DecreaseQualityWhenOutOfDate(item);
    }

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
        
        void jkjfaklsd(Item item)
        {
            if (item.Quality < maxItemQuality)
            {
                item.Quality += 1;

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < SomethingLikeThresholdOfBackstagePassesSellIn)
                    {
                        IncreaseQualityByOne(item);
                    }

                    if (item.SellIn < 6)
                    {
                        IncreaseQualityByOne(item);
                    }
                }
            }
        }
    }

    void DecreaseQualityWhenOutOfDate(Item item)
    {
        if (item.SellIn >= 0)
            return;

        switch (item.Name)
        {
            case "Aged Brie":
                IncreaseQualityByOne(item);
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                item.Quality -= item.Quality;
                break;
            default:
                DecrementQualityByOneIfNotSulfuras(item);
                break;
        }
    }
    
    void DecreaseSellInByOneIfNotSulfuras(Item item)
    {
        //Refactor 1: envidia de características.
        if (item.Name != "Sulfuras, Hand of Ragnaros")
        {
            item.SellIn -= 1;
        }
    }
    
    void DecrementQualityByOneIfNotSulfuras(Item item)
    {
        //Refactor 1: envidia de características.
        if (item.Quality > 0)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality -= 1;
            }
        }
    }
    
    void IncreaseQualityByOne(Item item)
    {
        //Refactor 1: envidia de características.
        if (item.Quality < maxItemQuality)
        {
            item.Quality += 1;
        }
    }
}