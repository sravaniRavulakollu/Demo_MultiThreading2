using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Demo_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Multitasking using multithread");
            MyClass History = new MyClass();
            Console.WriteLine("main thread started...");
            History.Display();




            //creating a new threadStart
            ThreadStart Th1 = History.Display;
            ThreadStart Th2 = History.Read;
            //Creating Instance of Thread class
            Thread s1 = new Thread(Th1);
            Thread s2 = new Thread(Th2);
            s1.Start();
            s2.Start();



            Console.WriteLine("Main Thread ends here.....!!");
            Console.ReadKey();
        }
    }
}