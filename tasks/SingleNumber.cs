using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class SingleNumber
    {
        int [] nums = {1,1,4};
    
          public void Numbers() {
         foreach (var i in nums){

              int count = 0;

              foreach (var j in nums){
                  if (i == j){
                    count++;
              }
         }
                if (count == 1){

                        System.Console.WriteLine(i);
                    }
                  }
     }
      
    }
}