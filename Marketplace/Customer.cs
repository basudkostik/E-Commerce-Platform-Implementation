using System;
using System.Collections.Generic;

namespace Marketplace
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private List<marketItem> shoppingList;
        public decimal TotalSpent { get; private set; }

        public Customer(string name, string email)
        {
            Name = name;
            shoppingList = new List<marketItem>();
            Email = email;
            TotalSpent = 0;
        }

        public void AddToShoppingList(marketItem obj)
        {
            shoppingList.Add(obj);
        }

        public List<marketItem> GetShoppingList()
        {
            return shoppingList;
        }

        public void Purchase(marketItem obj, int quantity)
        {
            TotalSpent += obj.Price * quantity;
        }
    }
}
