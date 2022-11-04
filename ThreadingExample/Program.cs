using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingExample
{
        class Program
        {
            public static void function1()
            {
                for (int index = 1; index < 10; index++)
                {
                    Console.WriteLine("Function_1= " + index);
                    Thread.Sleep(3000);
                }
            }
            public static void function2()
            {
                for (int index = 1; index < 10; index++)
                {
                    Console.WriteLine("Function_2= " + index);
                    Thread.Sleep(5000);
                }
            }
            public static void function3()
            {
                for (int index = 1; index < 10; index++)
                {
                    Console.WriteLine("Function_3= " + index);
                    Thread.Sleep(8000);
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("---MULTITHREADING---");
                Thread thread1 = new Thread(function1);
                thread1.Start();                         //Thread1
                Thread thread2 = new Thread(function2);
                thread2.Start();                         //Thread2
                Thread thread3 = new Thread(function3);
                thread3.Start();                         //Thread2
                Console.ReadLine();
            }
        }
    
}

