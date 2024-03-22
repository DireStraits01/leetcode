using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class RekArray
    {
     
       
        public int Action(int[] array,int i){
    
            if (i > array.Length-1) return 0;
            int result = array[i] + Action(array, i+1);
            System.Console.WriteLine(result);
            return result;
        }
    }
}