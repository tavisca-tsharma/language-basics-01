using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main");
            Test("42*47=1?74");
            Test("4?*47=1974");
            Test("42*?7=1974");
            Test("42*?47=1974");
            Test("2*12?=247");
            //Console.ReadKey(true);
        }

        private static void Test(string args)
        {
            //Console.WriteLine(args);
            Console.WriteLine(FindDigit(args));
        }

        public static int FindDigit(string equation)
        {
            //Console.WriteLine("FindDigit");
            int index=0, questionIndex=-1, starIndex = -1;
            string num1="";
            string num2, num3;
            int missingDigit=0;

            while (equation[index] !='='){
                //Console.WriteLine(equati)
                if (equation[index] == '?') {
                    questionIndex = index;
                }
                else if (equation[index] == '*')
                {
                    starIndex = index;
                    num1= equation.Substring(0, index);
                }
                index++;
            }
            num2 = equation.Substring(starIndex + 1, index - starIndex - 1);
            num3 = equation.Substring(index + 1);

            if (questionIndex == -1)
            {
                index = 0;
                while (num3[index] != '?')
                    index++;
                missingDigit = Calculation.Multiply(Convert.ToInt32(num1), Convert.ToInt32(num2), num3, index);
            }

            else if (questionIndex < starIndex)
                missingDigit = Calculation.Divide(Convert.ToInt32(num3), Convert.ToInt32(num2), num1, questionIndex);

            else
            {
                questionIndex = questionIndex - starIndex - 1;
                //Console.WriteLine
                missingDigit = Calculation.Divide(Convert.ToInt32(num3), Convert.ToInt32(num1), num2, questionIndex);
            }

            return missingDigit;
        }

        

    }
}
