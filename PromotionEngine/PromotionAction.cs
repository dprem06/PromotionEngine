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

        public int calculateTotal(int scenario)
        {
            // Prepare Cart List
            var cart = _promotionService.PrepareCartList(scenario);

            // Prepare Total
            int total = _promotionService.CalculateTotal(cart);

            return total;
        }
    }
}
