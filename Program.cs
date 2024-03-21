using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace leetcode.tasks;
internal class Program
{
   static void Main(){
         int [] numb = [1,3,4,5,3,5];
       var target = new RekArray();
       target.Action(numb, 0);
   }
}
