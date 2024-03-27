using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace leetcode.tasks;
internal class Program
{
   static void Main(){

      List<Task> toDoList = new List<Task>();
      Task task = new Task();
       System.Console.WriteLine(
         $"in your list {toDoList.Count}\nFor add new task enter E"
       );
       ConsoleKeyInfo orderInput =Console.ReadKey();
       if (orderInput.KeyChar.ToString() == "E"){
         System.Console.WriteLine("\nAdd new task for task list: Title");
         string taskTitle = Console.ReadLine();
         task.Title = taskTitle;
         foreach(var t in toDoList){
              System.Console.WriteLine(t.Title);
         }
       }
       System.Console.WriteLine(orderInput.KeyChar);
   }
}
