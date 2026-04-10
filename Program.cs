using System;
using System.Collections.Generic;
using System.Collections;

namespace RPNEvaluator {

    class RPNEvaluator {
        private static int PerformOp(int operand1, int operand2, string op) {
            switch(op) {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                case "%":
                    return operand1 % operand2;
            }
            
            return Int32.MaxValue;
        }

        public static int Evaluate(string s, Dictionary<string,int> D) {
            Stack stack = new Stack();
            string[] tokens = s.Split(' ');

            foreach (string token in tokens) {
                bool isDigit = int.TryParse(token, out int result);
                if (isDigit) {
                    stack.Push(result);
                } else {
                    (int, int) operands = ((int)stack.Pop(), (int)stack.Pop());
                    result = PerformOp(operands.Item1, operands.Item2, token);
                    // TODO error handling
                    stack.Push(result);
                }
            }

            return 1;
        }

        public static float Evaluatef(string s, Dictionary<string,float> D) {
            return 1;
        }
        
        public static float Evaluatef(string s, Dictionary<string,int> D) {
            return 1;
        }
    }
}
