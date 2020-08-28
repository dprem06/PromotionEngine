using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Data
{
    public class CartItems
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class Cart
    {
        public List<CartItems> ListCartItems { get; set; }

        public List<int> PromotionCodes { get; set; }

        public int Total { get; set; }
    }
}
