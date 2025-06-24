namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void DecrementQuality()
    {
        if (Quality <= 0)
            return;
        
        if (Name == "Sulfuras, Hand of Ragnaros")
            return;
        
        Quality -= 1;
    }
}