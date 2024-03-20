using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.tasks
{
    public class Parentheses
    {

        public void Action(){
            string s = "()";
            var left = new Stack<string>();
            foreach(var c in s.ToCharArray()){
                if (c == '(' || c == '[' || c == '{'){
                    left.Push(c.ToString());
                }
                else if (c == ')' && left.Count != 0 && char.Parse(left.Peek()) == '('){
                    left.Pop();
                }
                else if ( c == ']' && left.Count != 0 && char.Parse(left.Peek()) == '['){
                    left.Pop();
                }
                else if (c == '}' && left.Count != 0 && char.Parse(left.Peek()) == '{'){
                    left.Pop();
                }
                else{
                    System.Console.WriteLine("error");
                }
            }
            System.Console.WriteLine("true");
        }
    }
}