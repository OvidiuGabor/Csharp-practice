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
            var input = new int[8] { 3, 2, 5, 5, 1, 0, 7, 8 };

            //Sorting.ShellSort(input);
            //Stopwatch watcher = Stopwatch.StartNew();
            //Console.Write(input.ToArray());
            ////var result = CalculateTriplets.Count(input.ToArray());
            //BubbleSort(input.ToArray());
            //Console.Write(input.ToArray());

            PracticeSort.InsertionSort(input);
            Console.ReadLine();

        }

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
