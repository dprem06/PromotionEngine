using PromotionEngine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Services
{
    public class PromotionService : IPromotionService
    {
        /// <summary>
        /// List of aplicable promotions
        /// </summary>
        /// <param name="lstPromotion">List of promotion id</param>
        /// <returns>Promotions</returns>
        public IEnumerable<Promotion> GetPromotionList(List<int> lstPromotion)
        {
            var lstPromotionCodes = new List<Promotion>()
            {
                new Promotion(){ Id = 1, PromotionCode = "Buy 5", SkuNames = new List<PromotionSkuItem>(){ new PromotionSkuItem() { Id = 1, Name = "A", Count = 3 } } , DiscountPrice = 130, IsActive = true },
                 new Promotion(){ Id = 2, PromotionCode = "Buy 3", SkuNames = new List<PromotionSkuItem>(){ new PromotionSkuItem() { Id = 2, Name = "B", Count = 2 } } , DiscountPrice = 45, IsActive = true },
                  new Promotion(){ Id = 3, PromotionCode = "Buy C + D",SkuNames = new List<PromotionSkuItem>(){ new PromotionSkuItem() { Id = 3, Name = "C", Count = 1 }, new PromotionSkuItem() { Id = 4, Name = "D", Count = 1 } } , DiscountPrice = 30, IsActive = true }
            };

            lstPromotionCodes = lstPromotionCodes.Where(x => lstPromotion.Contains(x.Id)).ToList();
            return lstPromotionCodes.AsEnumerable();
        }

        /// <summary>
        /// Get price of sku item
        /// </summary>
        /// <param name="id">sku id</param>
        /// <returns>price of sku</returns>
        public int GetSkuPriceById(int id)
        {
            var lstSkuPriceList = new List<SkuPriceList>()
            {
                new SkuPriceList() {Id = 1, Name = "A", Price = 50},
                new SkuPriceList() {Id = 2, Name = "B", Price = 30},
                new SkuPriceList() {Id = 3, Name = "C", Price = 20},
                new SkuPriceList() {Id = 4, Name = "D", Price = 15},
            };


            return lstSkuPriceList.Where(x => x.Id == id).ToList()[0].Price;
        }

        /// <summary>
        /// Prepare cart list
        /// </summary>
        /// <param name="scenario">scrnario no-ex:1</param>
        /// <returns>Cart list and promotion list</returns>
        public Cart PrepareCartList(int scenario)
        {
            var lstCartItems = new List<CartItems>();
            switch (scenario)
            {
                case 1:
                    {
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 3, Name = "C" });

                        break;
                    }
                case 2:
                    {
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 3, Name = "C" });

                        break;
                    }

                case 3:
                    {

                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 3, Name = "C" });
                        lstCartItems.Add(new CartItems() { Id = 4, Name = "D" });

                        break;
                    }
                case 4:
                    {

                        lstCartItems.Add(new CartItems() { Id = 1, Name = "A" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 2, Name = "B" });
                        lstCartItems.Add(new CartItems() { Id = 3, Name = "C" });
                        lstCartItems.Add(new CartItems() { Id = 4, Name = "D" });
                        lstCartItems.Add(new CartItems() { Id = 4, Name = "D" });

                        break;
                    }

                default:
                    return null;
            }

            var cart = new Cart()
            {
                ListCartItems = lstCartItems,
                PromotionCodes = new List<int>() { 1, 2, 3 }
            };

            return cart;
        }
    }
}
