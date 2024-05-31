using System;
using System.Collections.Generic;
using System.IO;

namespace Marketplace
{
    public class marketItem : IComparable<marketItem>
    {
        public enum ObjectType
        {
            Computers,
            HomeAppliances,
            Clothing,
            Stationery_Office,
            Hardware,
            Garden,
            Textiles,
            Food
        }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Review { get; set; }
        public ObjectType Type { get; set; }
        public static List<marketItem> ReadObjectsFromFile(string filePath)
        {
            var objects = new List<marketItem>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                objects.Add(new marketItem
                {
                    Category = parts[0],
                    Brand = parts[1],
                    Model = parts[2],
                    Quantity = int.Parse(parts[3]),
                    Price = decimal.Parse(parts[4]),
                    Review = parts.Length > 5 ? parts[5] : string.Empty
                });
            }
            return objects;
        }

        public override string ToString()
        {
            return $"{Category} - {Brand} - {Model} - {Price:C} - {Quantity} - {Review}";
        }
        public int CompareTo(marketItem other)
        {
            if (other == null) return 1;

            // Compare based on Price, for example
            return this.Price.CompareTo(other.Price);
        }
    }
}
