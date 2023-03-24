namespace StockAccountManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of stocks: ");
            int numStocks = int.Parse(Console.ReadLine());


            StockPortfolio portfolio = new StockPortfolio();

            for (int i = 1; i <= numStocks; i++)
            {
                Console.WriteLine("\n**************\n");
                Console.Write("Enter the stock name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the number of shares: ");
                int numShares = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the share price: ");
                decimal sharePrice = Convert.ToDecimal(Console.ReadLine());

                Stock stock = new Stock();
                stock.Name = name;
                stock.NumShares = numShares;
                stock.SharePrice = sharePrice;

                portfolio.AddStock(stock);
            }

            portfolio.PrintReport();

        }
    }
}