using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class lib1
    {

        static public string stpow(string a, int b)
        {

            string nstr = "";
            for (int i = 0; i<b;i++)
            {
                nstr += a;
            }
            return nstr;

        }

        static public string rev(string a)
        {

            string nstr = "";

            for (int i = a.Length-1; i >= 0; i--)
            {
                nstr += a[i];
            }

            return nstr;

        }

        static public string remov(string str, string s)
        {

            string nstr = str.Replace(s,"");

            return nstr;
        }

        static public int leng(string str)
        {

            return str.Length;


        }

    }
}
