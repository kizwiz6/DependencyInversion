﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Cart : ICart
    {
        // List of cart items (product and quantity).
        private readonly List<(Product product, int quantity)> _items = new List<(Product product, int quantity)>();

        private readonly ILogger _logger;

        public Cart(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void AddProduct(Product product, int quantity)
        {
            // Check if the product is already in the cart.
            var existingItem = _items.FirstOrDefault(item => item.product.Id == product.Id);
            if (existingItem.product != null)
            {
                // If the product is already in the cart, update its quantity
                UpdateQuantity(product, existingItem.quantity + quantity);
            }
            else
            {
                // Otherwise, add a new item to the cart.
                _items.Add((product, quantity));
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach(var (product, quantity) in _items)
            {
                total += product.Price * quantity;
            }
            return total;
        }

        public void RemoveProduct(Product product)
        {
            _items.RemoveAll(item => item.product.Id == product.Id);
        }

        public void UpdateQuantity(Product product, int quantity)
        {
            try
            {
                // Ensure that the quantity is not negative
                if (quantity < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative.");
                }

                // Remove the product from the cart if the quantity is zero
                if (quantity == 0)
                {
                    RemoveProduct(product);
                    return;
                }

                // Find the item in the cart and update its quantity
                var item = _items.FirstOrDefault(item => item.product.Id == product.Id);
                if (item.product != null)
                {
                    _items[_items.IndexOf(item)] = (item.product, quantity);
                }
                else
                {
                    // If the product is not in the cart, add it
                    _items.Add((product, quantity));
                }
            }
            catch (ArgumentException ex)
            {
                // Log the exception and rethrow it
                _logger.Handle($"Failed to update quantity for product {product.Name}: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Handle other types of exceptions
                _logger.Handle($"An unexpected error occurred while updating quantity for product {product.Name}: {ex.Message}");
                throw; // Rethrow the exception to propagate it up the call stack
            }
        }

        public List<(Product product, int quantity)> GetItems()
        {
            return _items;
        }
    }
}
