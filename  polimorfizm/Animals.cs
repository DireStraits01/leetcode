using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class Animals
    {
        // protected метод доступен для дочерних классов и для модивикации метода(но не доступен для экземляров класса Animals)
       protected virtual void MakeSounds(){
             System.Console.WriteLine("Animal makes a sound:");
        }
    }
}