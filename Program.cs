using System;
using System.Threading.Tasks;

namespace TPL_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo for task parallel library!");

            //first method
            var task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("This is the first method to create and start a task using TPL");
            });
            task1.Wait();
            //Second method to create a Task using TPL  
            var task2 = new Task(() =>
            {
                Console.WriteLine("This is the second method to create a task using TPL");
            });
            // Next, we have to start the Task  
            task2.Start();
            task2.Wait();
            Console.Write("Program Complete...");
            Console.ReadKey();
        }
    }
 }

