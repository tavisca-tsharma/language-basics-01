using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Calculation
    {

        public static int Divide(int dividend, int question, string givenAnswer, int questionIndex)
        {
            //Console.WriteLine("divide");
            if (dividend % question != 0)
                return -1;

            int answer = dividend / question;
            string actualAnswer = Convert.ToString(answer);
            if (actualAnswer.Length != givenAnswer.Length)
                return -1;

            if (questionIndex > 0 && !actualAnswer.Substring(0, questionIndex).Equals(givenAnswer.Substring(0, questionIndex)))
                return -1;

            if (questionIndex < (actualAnswer.Length - 1) && !actualAnswer.Substring(questionIndex + 1).Equals(givenAnswer.Substring(questionIndex + 1)))
                return -1;

            return Convert.ToInt32(actualAnswer.Substring(questionIndex, 1));
        }

        public static int Multiply(int num1, int num2, String givenAnswer, int questionIndex)
        {
            //Console.WriteLine("multiply");
            int answer = num1 * num2;
            string actualAnswer = Convert.ToString(answer);
            if (actualAnswer.Length != givenAnswer.Length)
                return -1;

            if (questionIndex > 0 && !actualAnswer.Substring(0, questionIndex).Equals(givenAnswer.Substring(0, questionIndex)))
                return -1;

            if (questionIndex < (actualAnswer.Length - 1) && !actualAnswer.Substring(questionIndex + 1).Equals(givenAnswer.Substring(questionIndex + 1)))
                return -1;

            int num = Convert.ToInt32(actualAnswer.Substring(questionIndex, 1));
            return num;
        }

    }
}
