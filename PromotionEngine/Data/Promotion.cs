using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Data
{
    public class Promotion
    {
        public int Id { get; set; }

        public string PromotionCode { get; set; }

        public List<PromotionSkuItem> SkuNames { get; set; }

        public int DiscountPrice { get; set; }

        public bool IsActive { get; set; }
    }

    public class PromotionSkuItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }
    }
}
