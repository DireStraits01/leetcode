using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class Factorial
    {
        public int Action(int n){
            if(n<1) return 1;
            int result = n * Action(n-1);
            return result;
        }
    }
}