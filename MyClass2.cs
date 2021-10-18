using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace Demo_Multithreading
{
    class MyClass
    {
        public void Display()
        {
            Console.WriteLine("Implementing Thread1");



            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("\n {0}", i);
            }
            Console.WriteLine("thread1 closes");
        }



        public void Read()
        {
            Console.WriteLine("Implementing Thread2");
            for (char j = 'A'; j < 'Z'; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Thread 2 closes");
        }
    }
}
