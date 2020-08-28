using Microsoft.Extensions.DependencyInjection;
using PromotionEngine.Services;
using System;

namespace PromotionEngine
{
    class Program
    {
        static void Main()
        {
            // Injecting Services
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IPromotionService, PromotionService>()
                .BuildServiceProvider();

            var promotionService = serviceProvider.GetService<IPromotionService>();

            PromotionAction objEngine = new PromotionAction(promotionService);
            int total = objEngine.CalculateTotal(1);
            Console.Write("Cart Total:" + total);
        }
    }
}
