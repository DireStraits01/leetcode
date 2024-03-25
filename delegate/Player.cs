using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class Player
    {
        public int Points {get; private set;}
        public delegate void AchievmentUnlockedHandler(int points);
        public event AchievmentUnlockedHandler? AchievmentUnlocked;

        public async Task AddPoints(int points)
        {
            Points += points;
            System.Console.WriteLine($"Player earned {points} points. Total points: {Points}");
            await Task.Delay(1000);

            if (Points >= 100)
            {
                AchievmentUnlocked.Invoke(Points);
            }
        }
    }
}