using System;
using System.Collections.Generic;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var stack = new Stack<int>();
           foreach(var arg in args)
            {
                switch (arg.Substring(0, 1))
                {
                    //process the operator
                    case "+":
                        CalcFunctions.CalcAdd(stack);
                         break;

                    case "-":
                        CalcFunctions.CalcSub(stack);
                           break;
                    case "*":
                        CalcFunctions.CalcMult(stack);
                        break;

                    case "/":
                        CalcFunctions.CalcDiv(stack);
                        break;
                        // process the operator
                        break;


                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        //convert to integer....... Continue means go to next step.. push onto the stack. 
                        int i;
                        var converted = int.TryParse(arg, out i);
                        if (!converted) continue;
                        stack.Push(i);
                        break;

                        break;
                    default:
                        // throw it away
                        break;
                }
                
                
            }
            var ans1 = stack.Pop();
            Console.WriteLine($"{ans1}");

        }
    }
}
