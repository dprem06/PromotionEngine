using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using PromotionEngine.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Tests
{
    [TestClass()]
    public class PromotionActionTests
    {
        private readonly IPromotionService _promotionService;
        public PromotionActionTests()
        {
            _promotionService = new PromotionService();
        }

        [TestMethod()]
        public void TestScenario1()
        {
            // Prepare Cart List
            var cart = _promotionService.PrepareCartList(1);

            // Prepare Total
            int total = _promotionService.CalculateTotal(cart);

            Assert.AreEqual(100, total);
        }

        [TestMethod()]
        public void TestScenario2()
        {
            // Prepare Cart List
            var cart = _promotionService.PrepareCartList(2);

            // Prepare Total
            int total = _promotionService.CalculateTotal(cart);

            Assert.AreEqual(370, total);
        }

        [TestMethod()]
        public void TestScenario3()
        {
            // Prepare Cart List
            var cart = _promotionService.PrepareCartList(3);

            // Prepare Total
            int total = _promotionService.CalculateTotal(cart);

            Assert.AreEqual(280, total);
        }
    }
}