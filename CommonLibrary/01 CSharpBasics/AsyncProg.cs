using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLibrary._01_CSharpBasics
{
    public static class AsyncAwait
    {
        public static async void SomeFunc()
        {
            Console.WriteLine("Some method started!");
            await Task.Delay(5000);
            Console.WriteLine("Some method ended");
        }
    }

    public static class ParallelProg
    {
        public static void someFunc2()
        {
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                //Thread.CurrentThread.ManagedThreadId returns an integer that 
                //represents a unique identifier for the current managed thread.
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            });
        }

        public static void SeqLoop()
        {
            DateTime StartDateTime = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("For Loop Execution start");
            stopWatch.Start();
            for (int i = 0; i < 10; i++)
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            }
            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine("For Loop Execution end ");
            stopWatch.Stop();
            Console.WriteLine($"Time Taken to Execute the For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");
        }

        public static void ParallelLoop()
        {
            DateTime StartDateTime = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Parallel For Loop Execution start");
            stopWatch.Start();

            Parallel.For(0, 10, i =>
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            });
            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine("Parallel For Loop Execution end ");
            stopWatch.Stop();
            Console.WriteLine($"Time Taken to Execute Parallel For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");
        }

        public static long DoSomeIndependentTask()
        {
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;

        }
        public static class prac
        {
            public static int id;
        }
    }
   
}
