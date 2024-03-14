using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace leetcode.tasks
{
    public class BinaryTree
    {
        public void Action(){
            var p = new int[]{1,2,3};
            var q = new int []{2,1,4};
            int count = 0;
            for (int i = 0; i < p.Length; i++){
          for (int j = 0; j < q.Length; j++){
               if (p[i] == q[j]){
                count++;
               }
    
            }
            }if(count == 3) System.Console.WriteLine("true");
            System.Console.WriteLine(false);
        }
    }
}