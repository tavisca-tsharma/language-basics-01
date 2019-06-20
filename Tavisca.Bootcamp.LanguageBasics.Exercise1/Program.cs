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
            int i=0, index=-1, star=-1;
            string a="";
            string b, c;

            while (!equation.Substring(i, 1).Equals("=")){
                //Console.WriteLine(equati)
                if (equation.Substring(i, 1).Equals("?")) {
                    index=i;
                }
                else if (equation.Substring(i, 1).Equals("*")){
                    star = i;
                    a=equation.Substring(0, i);
                }
                i++;
            }
            b=equation.Substring(star+1, i-star-1);
            c=equation.Substring(i+1);
            
            if (index == -1){
                i=0;
                while (!c.Substring(i, 1).Equals("?"))
                    i++;
                return multiply ( Convert.ToInt32(a), Convert.ToInt32(b), c, i );
            }
            
            if (index < star)
                return divide ( Convert.ToInt32(c), Convert.ToInt32(b), a, index );
            
            //Console.WriteLine("star="+star+", index= "+index);
            index = index-star-1;
            //Console.WriteLine
            return divide ( Convert.ToInt32(c), Convert.ToInt32(a), b, index );
        }

        public static int divide(int d, int q, string r, int index){
            //Console.WriteLine("divide");
            if (d%q!=0)
                return -1;
            
            int e = d/q;
            string s = Convert.ToString(e);
            if (s.Length!=r.Length)
                return -1;
                        
            if (index>0 && !s.Substring(0, index).Equals(r.Substring(0, index)))
                return -1;
            
            if (index<(s.Length-1) && !s.Substring(index+1).Equals(r.Substring(index+1)))
                return -1;
            
            return Convert.ToInt32(s.Substring(index, 1));
        }

        public static int multiply(int x, int y, String r, int index){
            //Console.WriteLine("multiply");
            int e = x*y;
            string s = Convert.ToString(e);
            if (s.Length!=r.Length)
                return -1;
                        
            if (index>0 && !s.Substring(0, index).Equals(r.Substring(0, index)))
                return -1;
            
            if (index<(s.Length-1) && !s.Substring(index+1).Equals(r.Substring(index+1)))
                return -1;
            
            int j= Convert.ToInt32(s.Substring(index, 1));
            return j;
        }

    }
}
