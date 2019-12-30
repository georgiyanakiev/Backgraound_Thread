using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdvancedTasks
{
    public static class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("Thread process: {0}", i);
                Thread.Sleep(0);
            }
        }



        public static void Main(string[] args)
        {

            bool stop = false;
            Thread t = new Thread(new ThreadStart(() =>

            {
                while (!stop)
                {
                    Console.WriteLine("Thread is running...");
                    Thread.Sleep(2000);
                }

            }));
            //t.IsBackground = true;
            t.Start();
            t.Join();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

            stop = true;


            t.Join();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("This is main Thread!");
            //    Thread.Sleep(0);
            //}
            //t.Join();
            //Console.ReadLine();
        }
    }
}
