using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemoV2
{
    public delegate void NotificationDelegate(string txt);
    public delegate void VoidDelegate();

    public class Program
    {
        static void Main(string[] args)
        {
            //NotificationDelegate del = (txt) => Console.WriteLine(txt);
            NotificationDelegate del = txt => Console.WriteLine(txt);

            del += txt => 
            {
                string path = "";
                File.AppendAllText(path, txt);
            };

            VoidDelegate voidDel = () => Console.WriteLine("I am a Void");
            voidDel.Invoke();

            Console.ReadKey();
        }
    }
}
