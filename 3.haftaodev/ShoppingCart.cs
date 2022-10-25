using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.haftaodev
{
    internal class ShoppingCart
    {
        private List<CartItem> cartItems;

        public ShoppingCart()
        {
            cartItems = new List<CartItem>();
        }

        public void Add(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }

        public void Remove(int id)
        {
            var removed = cartItems.FirstOrDefault(x => x.CartId == id);
            if (removed == null)
            {
                Console.WriteLine($"Not found.");
                return;
            }
            cartItems.Remove(removed);

        }

        

        public void GetList()
        {
            foreach (var cartItem in cartItems)
            {
                Console.WriteLine(cartItem);
            }
        }
    }
}
