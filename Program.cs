using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace leetcode.tasks;
internal class Program
{
   static async Task Main(){
      StockExchangeMonitor stockMonitor = new StockExchangeMonitor();
      stockMonitor.PriceChangeHandler = ShowPrice;
      stockMonitor.Start();
       
   }

   public static void ShowPrice(int price)
   {
      System.Console.WriteLine($"New price{price}");
   }
}
