using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_algo
{

    class Program
    {
       

        static void Main(string[] args)
        {

            //var input = Convert.InputFile(@"D:\Projects\C# Practice\Algorithms-CSharp-Course\Algorithms-CSharp-Course\Data\1Kints.txt");
            //var input = new int[8] { 3, 2, 5, 5, 1, 0, 7, 8 };

            //Sorting.ShellSort(input);
            //Stopwatch watcher = Stopwatch.StartNew();
            //Console.Write(input.ToArray());
            ////var result = CalculateTriplets.Count(input.ToArray());
            //BubbleSort(input.ToArray());
            //Console.Write(input.ToArray());

            //PracticeSort.InsertionSort(input);
            //ListDemo.Run();
            //Node first = new Node() { Value = 5 };
            //Node second = new Node() { Value = 1 };

            //first.Next = second;

            //Node third = new Node() { Value = 3 };
            //second.Next = third;


            //PrintOutLinKedList(first);

            Console.ReadLine();

        }
        //private static void PrintOutLinKedList(Node node)
        //{
        //    while (node != null)
        //    {
        //        Console.WriteLine(node.Value);
        //        node = node.Next;
        //    }
        //}

        private static int RecursiveFactorial(int number)
        {
            if (number == 0)
                return 1;

            return number * RecursiveFactorial(number - 1);
        }

       
        private static int IterativFactorial(int number)
        {
            if (number == 0)
                return 1;

            int sum = 1;

            for(int i = number; i > 0; i--)
            {
                sum *= i;
            }
            return sum;
        }


       

    }
}
