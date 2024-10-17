using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpessions
{
    public delegate int OperationDelegate(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {

            //OperationDelegate ops = delegate (int x, int y) { return x + y; };

            // 1. მოვაშოროთ ტიპები გადასაცემ პარამეტრებს:
            //OperationDelegate ops = delegate (x, y) { return x + y; };

            //2. delegate ქივორდის მოშორება და მისი ჩანაცვლება => (lambda = ლამბდა) ოპერატორით
            //OperationDelegate ops = (x, y) => { return x + y; };

            // 3. მოვაცილოთ return ქივორდი, რადგან დასაბრუნებელი ტიპი ისედავ
            // განსაზღვრულია დელეგატის გამოცხადის გამოცხადების დროს:
            //OperationDelegate ops = (x, y) => { x + y; };

            //4. რადგან კოდი 1 ხაზიანი {} შეგვიძლია წავუშალოთ:
            OperationDelegate ops = (x, y) => x + y;

            // შედეგად:
            //OperationDelegate ops = delegate (int x, int y) { return x + y; };

            //ჩანაცვლდა:
            //OperationDelegate ops = (x, y) => x + y; // ლამბდა გამოსახულება 

            ops += (x, y) => x * y;

            foreach (var op in ops.GetInvocationList()) 
            {
                Console.WriteLine(op.DynamicInvoke(2, 4));
            }

            Console.ReadKey();
            
        }
    }
}
