using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class RemoveElement
    {
        int[] nums = {1,2,3};
        int val = 2;
        int k = 0;
        public void Action(){
               int[] nums2 = new int[nums.Length];
               for (int i = 0; i < nums2.Length; i++){
                foreach(var n in nums){
                    if (n != val){
                        nums2[i] = n;
                    }
                }
               }
               foreach(var nm in nums2){
                System.Console.WriteLine(nm);
               }
        }
    }
}