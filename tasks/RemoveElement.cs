using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class RemoveElement
    {
        int[] nums = {3,2,2,3};
        int val = 3;
        int k = 0;
        public void Action(){
           for(int i = 0; i  < nums.Length; i++){
            if (nums[i] != val){
                nums[k] = nums[i];
                k++;
            }
           }
           
            }
        }
    }
