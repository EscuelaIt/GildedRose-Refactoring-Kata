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
        DecreaseSellInByOne(item);
        DecreaseQualityWhenOutOfDate(item);
    }

    void aklsjdflkadjf(Item item)
    {
        if (item.Name is "Aged Brie" or "Backstage passes to a TAFKAL80ETC concert")
        {
            IncreaseQualityOfSpecialCases(item);
        }
        else
        {
            item.DecrementQuality();
        }
    }
    
    void IncreaseQualityOfSpecialCases(Item item)
    {
        if (item.Quality >= maxItemQuality)
            return;
        item.Quality += 1;

        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
        {
            HandleBackstagePassQuality(item);
        }
    }

    void HandleBackstagePassQuality(Item item)
    {
        if (item.SellIn < SomethingLikeThresholdOfBackstagePassesSellIn)
        {
            item.IncrementQuality();
        }

        if (item.SellIn < 6)
        {
            item.IncrementQuality();
        }
    }

    void DecreaseQualityWhenOutOfDate(Item item)
    {
        if (item.SellIn >= 0)
            return;

        switch (item.Name)
        {
            case "Aged Brie":
                item.IncrementQuality();
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                item.Quality = 0; //Refactor 1: feature envy
                break;
            default:
                item.DecrementQuality();
                break;
        }
    }
    
    void DecreaseSellInByOne(Item item)
    {
        //Refactor 4: envidia de características.
        if (item.Name != "Sulfuras, Hand of Ragnaros")
        {
            item.SellIn -= 1;
        }
    }
}