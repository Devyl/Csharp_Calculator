using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calc
    {
       static public string Add(string a, string b)
        {
            int sum = 0;
            int c = Convert.ToInt32(a);
            //int c = Int32.TryParseParse(a);
            int d = Convert.ToInt32(b);
            //int d = Int32.Parse(b);
            sum = c + d;
            string ret = sum.ToString();
            //int c = Int32.Parse(sum);
            return ret;
        }
        static public string Substract(string a, string b)
        {
            int sum = 0;
            int c = Convert.ToInt32(a);
            //int c = Int32.TryParseParse(a);
            int d = Convert.ToInt32(b);
            //int d = Int32.Parse(b);
            sum = c - d;
            string ret = sum.ToString();
            //int c = Int32.Parse(sum);
            return ret;
        }
        static public string Dziel(string a, string b)
        {
            int sum = 0;
            int c = Convert.ToInt32(a);
            //int c = Int32.TryParseParse(a);
            int d = Convert.ToInt32(b);
            //int d = Int32.Parse(b);
            sum = c / d;
            string ret = sum.ToString();
            //int c = Int32.Parse(sum);
            return ret;
        }
        static public string Mnoz(string a, string b)
        {
            int sum = 0;
            int c = Convert.ToInt32(a);
            //int c = Int32.TryParseParse(a);
            int d = Convert.ToInt32(b);
            //int d = Int32.Parse(b);
            sum = c * d;
            string ret = sum.ToString();
            //int c = Int32.Parse(sum);
            return ret;
        }

        static public string CharCheck(char whatis, string a, string b)
        {
            switch (whatis)
            {
                case '+':
                    return Add(a, b);
                //break;
                case '-':
                    return Substract(a, b);
                //break;
                case '*':
                    return Mnoz(a, b);
                //break;
                case '/':
                    return Dziel(a, b);
                //break;
                default:
                    return a;
                    //reak;
            }

        }
    }
}
