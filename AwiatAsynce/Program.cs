// See https://aka.ms/new-console-template for more information
using System.Threading;




namespace AwiatAsynce // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task task1 = new Task(() => Work(1));
            Task task2 = new Task(() => Work(2));
            task1.Start();
            task2.Start();


            Console.WriteLine("Code 1");
            Console.WriteLine("Code 2");

            Print();

            Console.WriteLine("Code 7");
            Console.WriteLine("Code 8");

            Console.ReadKey();
        }


        public static void Work(int id)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ID is: { id }");
                Thread.Sleep(4000);
            }
        }
        public static async void Print()
        {

            Console.WriteLine("Code 3");
            Console.WriteLine("Code 4");

            await Task.Delay(3000);
            // Thread.Sleep(4000);

            Console.WriteLine("Code 5");
            Console.WriteLine("Code 6");

        }
    }
}
