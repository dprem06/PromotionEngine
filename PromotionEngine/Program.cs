using Microsoft.Extensions.DependencyInjection;
using PromotionEngine.Services;
using System;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Injecting Services
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IPromotionService, PromotionService>()
                .BuildServiceProvider();

            var promotionService = serviceProvider.GetService<IPromotionService>();
        }
    }
}
