﻿using PromotionEngine.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Services
{
    public interface IPromotionService
    {
        /// <summary>
        /// Get price of sku item
        /// </summary>
        /// <param name="id">sku id</param>
        /// <returns>price of sku</returns>
        int GetSkuPriceById(int id);

        /// <summary>
        /// List of aplicable promotions
        /// </summary>
        /// <param name="lstPromotion">List of promotion id</param>
        /// <returns>Promotions</returns>
        IEnumerable<Promotion> GetPromotionList(List<int> lstPromotion);
    }
}
