using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace leetcode.tasks;
internal class Program
{
   static async Task Main(){
         Player player = new Player();
         player.AchievmentUnlocked += OnAchievmentUnlocked;
         await player.AddPoints(30);
         await player.AddPoints(40);
         await player.AddPoints(45);

         static void OnAchievmentUnlocked()
         {
            System.Console.WriteLine($"COngratulation! unclocked!! ");
         }
       
   }
}
