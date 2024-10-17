using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_23.predicate
{
    public delegate bool MyDelegate(string txt);
    public class Program
    {
        static void Main(string[] args)
        {
            Action action = VoidMethod;
            Action<int, int> intAction = Method;

            //action.Invoke();
            //intAction(2,3);

            // მეთოდების ტიპები გვაქვს 3:
            // 1. void => Action
            // 2. bool => Predicate
            // 3. int, string, myclass, double, char ... => Func

            //MyDelegate del = IsLessThanSeven;
            //var boolResult = del("my str");
            //Console.WriteLine(boolResult);

            Predicate<string> isLessThanSeven = IsLessThanSeven;
            Console.WriteLine(isLessThanSeven("my string"));


            Console.ReadKey();
        }

        static bool IsLessThanSeven(string txt)
        {
            return txt.Length < 7 ? true : false;
        }

        static void VoidMethod()
        {
            Console.WriteLine("I am a Void");
        }

        static void Method(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
