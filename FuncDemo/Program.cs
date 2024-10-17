using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemo
{

    //public delegate T IntDelegate<T>(T a, T b, T c);
    public delegate double IntDlegate(int a, int b, int c); 

    public class Program
    {
        static void Main(string[] args)
        {
            //IntDelegate<int> intDel = IntMethod;
            //Console.WriteLine(intDel(1, 2, 3));

            //IntDelegate<string> strDel = StrMethod;
            //Console.WriteLine(strDel("a","b","c"));

            //IntDlegate intDel = IntMethod;
            //Console.WriteLine(intDel(1,2,3));

            Func<string> strFunc = GetStringValue; // თუ მითითებულია მხოლოდ 1
            // ტიპი, ნიშნავს მოცემული ტიპის დასაბრუნებელ მნიშვნელობას!


            // მრავალი ტიპის ჩამონათვალის შემთხვევაში, დასაბრუნებელი ტიპი არის ჩამონათვალის ბოლოში!
            Func<int, int, int, int, double> intFunc = GetIntValue;

            Console.ReadKey();
        }

        static string GetStringValue()
        {
            return "";
        }
        static double GetIntValue(int par1, int par2,int par3, int par4)
        {
            return 1;
        }


        static double IntMethod(int a, int b, int c)
        {
            return a + b + c; // implicit
        }

        //static string StrMethod(string s, string t, string r)
        //{
        //    return s + t + r;   
        //}
    }
}
