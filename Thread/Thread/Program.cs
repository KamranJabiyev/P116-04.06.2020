using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);
            thread1.Start();
            thread1.Join();
            thread2.Start();
        }

        static void Loop1()
        {
            for (int i = 0; i <= 100; i++)
            {
                //Thread.Sleep(1000);
                
                Console.WriteLine($"First:{i}");
            }
        }

        static void Loop2()
        {
            for (int i = 0; i <= 100; i++)
            {
                //Thread.Sleep(2000);
                Console.WriteLine($"Second:{i}");
            }
        }
    }
}
