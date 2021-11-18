using System;
using ShopApp.Models;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class LoggerService : ILoggerService
    {
        private static readonly LoggerService _instance = new LoggerService();
        static LoggerService()
        {
        }

        public static LoggerService Instance => _instance;
        public void SuccessfulTemplate(Sweet[] sweets)
        {
            for (var i = 0; i < sweets.Length; i++)
            {
                if (sweets[i] == null)
                {
                    break;
                }

                Console.WriteLine($"{i + 1}. '{sweets[i].Name}', type: {sweets[i].Type}, weight: {Math.Round(sweets[i].WeightInGm, 2)}gm, price: {Math.Round(sweets[i].PriceInUAH, 2)} UAH");
            }

            Console.WriteLine();
        }

        public void SuccessfulBuildLog(Sweet[] sweets, double giftWeight)
        {
            Console.WriteLine("Your gift was formed successfully! You can see the list of included items below:");
            Console.WriteLine();
            SuccessfulTemplate(sweets);
            Console.WriteLine($"Overall weight: {Math.Round(giftWeight, 2)}gm");
            Console.WriteLine();
        }

        public void SuccessfulSortLog(Sweet[] sweets)
        {
            Console.WriteLine("Your gift was sorted successfully. Results are below:");
            Console.WriteLine();
            SuccessfulTemplate(sweets);
        }

        public void SuccessfulSearchLog(Sweet[] sweets)
        {
            Console.WriteLine("Your query was processed successfully. Results are below:");
            Console.WriteLine();
            SuccessfulTemplate(sweets);
        }
    }
}
