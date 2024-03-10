using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class RemoveElement
    {
        int[] nums = [3,2,,3];
        int val = 2;
        int k = 0;
        public void Action(){
            
            for (int i = 0; i< nums.Length; i++){
                if(nums[i] != val){
                    nums[i] = nums[i];
                    k++;
                }
            }
            System.Console.WriteLine($"k - {k}");
            foreach (var n in nums){
                System.Console.WriteLine($"{n}");
            }
        }
    }
}