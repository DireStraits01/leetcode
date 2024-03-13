using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class TargetValue
    {
         int target = 2;
         int[] nums = [1,3,5,6];
        public void Action(){
        int index = 0;
       foreach(var i in nums){
        if (i == target){
            index = Array.IndexOf(nums, target);
        }
       }
         
        int[] nums2 = new int[nums.Length+1];
        nums.CopyTo(nums2, 0);
        nums2[nums2.Length-1] = target;
        Array.Sort(nums2);
        index = Array.IndexOf(nums, target);
        
        System.Console.WriteLine(index);
        // foreach(var n in nums2){
        //     System.Console.WriteLine(n);
        // }
        }
        
    }
}