using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace leetcode.tasks;
internal class Program
{
   static void Main(){

      var anim = new Animals();
      var lion  = new Animal("Lion", "yellow", 300, "Raaaauuuu");
      var cow  = new Animal("Cow", "white", 500, "mu");
      var delphin  = new Animal("Delphin", "gray", 250, "piu");
      Animal [] animalsArray = new Animal[]{lion, cow, delphin};
      foreach(var animal in animalsArray){
              animal.MakeSounds();
      }
   }
}
