using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Data
{
    public class SkuPriceList
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public bool IsActive { get; set; }
    }
}
