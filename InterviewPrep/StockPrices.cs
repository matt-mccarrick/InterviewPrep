using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class StockPrices
    {
        public int getMaxProfit(int[] stockPricesYesterday)
        {
            var maxProfitSoFar = 0;
            var minPriceSoFar = stockPricesYesterday[0];
            var maxPriceSoFar = stockPricesYesterday[0];

            for (int i = 0; i < stockPricesYesterday.Length; i++)
            {


                //If the current price is the lowest so far, update
                if (stockPricesYesterday[i] < minPriceSoFar)
                {
                    minPriceSoFar = stockPricesYesterday[i];
                    //reset maxPrice if we change minPrice further
                    maxPriceSoFar = 0;
                }
                if (stockPricesYesterday[i] > maxPriceSoFar)
                {
                    maxPriceSoFar = stockPricesYesterday[i];
                }
                var temp = maxPriceSoFar - minPriceSoFar;
                if (temp > maxProfitSoFar)
                {
                    maxProfitSoFar = temp;
                }
            }
            return maxProfitSoFar;
        }
    }
}
