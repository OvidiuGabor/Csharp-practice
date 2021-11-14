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

            var input = Convert.InputFile(@"D:\Projects\C# Practice\Algorithms-CSharp-Course\Algorithms-CSharp-Course\Data\4Kints.txt");

            Stopwatch watcher = Stopwatch.StartNew();

            var result = CalculateTriplets.Count(input.ToArray());

            Console.WriteLine($"Total Result is {result}");
            Console.WriteLine($"Total Time Taken is {watcher.Elapsed}");





            Console.ReadLine();

        }
    }
}
