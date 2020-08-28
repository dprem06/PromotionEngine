using PromotionEngine.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionAction
    {
        private readonly IPromotionService _promotionService;
        public PromotionAction(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        public int calculateTotal()
        {
            return 0;
        }
    }
}
