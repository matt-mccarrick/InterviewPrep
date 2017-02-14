using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockPrice = new StockPrices();
            stockPrice.getMaxProfit(new[] {10, 7, 5, 8, 11, 9});
        }
    }
}
