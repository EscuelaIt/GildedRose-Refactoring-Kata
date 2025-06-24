using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            Item.With("+5 Dexterity Vest", 10, 20),
            AgedBrie.With(sellIn: 2, quality: 0),
            Item.With("Elixir of the Mongoose", 5, 7),
            Sulfuras.With(sellIn: 0, quality: 80),
            Sulfuras.With(sellIn: -1, quality: 80),
            BackstagePass.With(15, 20),
            BackstagePass.With(10, 49),
            BackstagePass.With(5, 49),
            Item.With("Conjured Mana Cake", 3, 6)
        };

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.EndDay();
        }
    }
}