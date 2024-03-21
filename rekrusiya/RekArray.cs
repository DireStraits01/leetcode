using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class RekArray
    {
        int [] numb = [1,3,4,5,3,5];
         int number = 561;
         int sum = 0;
        public void Action(int i){
        char[] numberArray = number.ToString().ToCharArray();
        if(i > numberArray.Length -1) {
            System.Console.WriteLine($"sum of numbers: {sum}");
            return;
        }
        int num = (int)numberArray[i];
        sum +=  num - '0';
          i++;
          Action(i);
         
        }
    }
}