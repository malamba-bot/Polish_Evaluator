using System;
using System.Collections.Generic;
using System.Collections;

namespace RPNEvaluator {

    class RPNEvaluator {
        public static int Evaluate(string s, Dictionary<string,int> D) {
            Stack stack = new Stack();
            string[] tokens = s.Split(' ');

            foreach (string token in tokens) {
                bool isDigit = int.TryParse(token, out int result);
                if (isDigit) {
                    stack.Push(result);
                } else {
                    (int, int) operands = ((int)stack.Pop(), (int)stack.Pop());
                    int j = operands.Item1;
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
