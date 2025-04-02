using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class _121BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int buy_price = prices[0], current_profit = 0, profit = 0;
            foreach (var price in prices)
            {
                if (price < buy_price)
                {
                    buy_price = price;
                }
                current_profit = price - buy_price;
                if (current_profit > profit)
                {
                    profit = current_profit;
                }
            }
            return profit;
        }
    }
}
