using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class Animal:Animals
    {
        private string Name{get; set;}
        private string Color{get; set;}
        private int Weight{get; set;}
        private string Sound {get; set;}
        public Animal(string name, string color, int weight, string sound){
              Name = name;
              Color = color;
              Weight = weight;
              Sound = sound;
        }

        public new void MakeSounds()
        {
            base.MakeSounds();
            System.Console.WriteLine(Sound);
        }
    }
}