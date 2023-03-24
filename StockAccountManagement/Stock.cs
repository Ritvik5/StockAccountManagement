using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class Stock
    {
        public string Name { get; set; }
        public int NumShares { get; set; }
        public decimal SharePrice { get; set; }

        public decimal GetStockValue()
        {
            return NumShares * SharePrice;
        }
    }

    public class StockPortfolio
    {
        List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public decimal GetTotalStockValue()
        {
            decimal totalStockValue = 0;

            foreach (Stock stock in stocks)
            {
                totalStockValue += stock.GetStockValue();
            }

            return totalStockValue;
        }

        public void PrintReport()
        {
            Console.WriteLine("Stock Report:");
            Console.WriteLine("\n**********\n");

            foreach (Stock stock in stocks)
            {
                decimal value = stock.GetStockValue();
                Console.WriteLine(stock.Name+" "+stock.NumShares+" shares at price "+stock.SharePrice+" : "+value);
            }

            decimal totalValue = GetTotalStockValue();
            Console.WriteLine("\n*************\n");
            Console.WriteLine("Total value of all stocks: "+totalValue);
        }
    }
}
