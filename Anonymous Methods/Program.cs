using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Anonymous_Methods
{
    public delegate void NotificationDelegate(string txt);
    public delegate int OperationDelegate(int x, int y);
    public class Program
    {
        static void Main(string[] args)
        {
            //NotificationDelegate del = DisplayInConsole;
            //del += WriteIntoLogs;
            //del("Some Notification");

            // Using Anonymous Methods
            NotificationDelegate del = delegate (string txt) { Console.WriteLine(txt); };
            del += delegate (string txt)
            {
                string path = @"C:\Users\admin\source\repos\data.txt";
                File.AppendAllText(path, txt);
            };

            del("Anonymous Methods");

            OperationDelegate ops = delegate (int x, int y) { return x + y; };
            ops += delegate (int x, int y) { return x * y; };

            foreach (var method in ops.GetInvocationList())
            {
                Console.WriteLine(method.DynamicInvoke(2,3));
            }

            Console.ReadKey();  
        }

        //static void DisplayInConsole(string txt)
        //{
        //    Console.WriteLine(txt);
        //}

        //static void WriteIntoLogs(string msg)
        //{
        //    string path = "";
        //    File.WriteAllText(path, msg);
        //}
    }
}
