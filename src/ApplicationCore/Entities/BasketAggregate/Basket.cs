﻿using ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationCore.Entities.BasketAggregate
{
    public class Basket : BaseEntity, IAggregateRoot
    {
        public string BuyerId { get; set; }

        private readonly List<BasketItem> _items = new List<BasketItem>();

        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();

        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if (!Items.Any(i => i.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem
                {
                    CatalogItemId = catalogItemId,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                });

                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            existingItem.Quantity += quantity;
        }
    }
}
