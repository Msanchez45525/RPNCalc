using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator
{
    class CalcFunctions
    {
        public static int CalcAdd(Stack<int> stack)
        {
         
            var op1 = stack.Pop();
            var op2 = stack.Pop();
            var ans = op1 + op2;
            stack.Push(ans);
            return ans;
            
        }

        public static int CalcSub(Stack<int> stack)
        {
            
           var  op1 = stack.Pop();
           var  op2 = stack.Pop();
           var ans = op1 - op2;
            stack.Push(ans);
            return ans;
        }


        public static int CalcMult(Stack<int> stack)
        {
            
            var op1 = stack.Pop();
            var op2 = stack.Pop();
            var ans = op1 * op2;
            stack.Push(ans);
            return ans;
        }


        public static int CalcDiv(Stack<int> stack)
        {
            
            var op1 = stack.Pop();
            var op2 = stack.Pop();
            var ans = op1 / op2;
            stack.Push(ans);
            return ans;

        }








    }
}
