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

            //var input = Convert.InputFile(@"D:\Projects\C# Practice\Algorithms-CSharp-Course\Algorithms-CSharp-Course\Data\4Kints.txt");

            //Stopwatch watcher = Stopwatch.StartNew();

            //var result = CalculateTriplets.Count(input.ToArray());

            //Console.WriteLine($"Total Result is {result}");
            //Console.WriteLine($"Total Time Taken is {watcher.Elapsed}");
            //ArraysDemo();
            //Console.ReadLine();

            //Test1BasedArray();

            //MultiDimArrays();

            //JaggedArrays();

            //IterateOver(new int[4] { 1, 2, 3, 4 });



            Console.ReadLine();
        }




        static void ArrayTimeComplexity(object[] array)
        {
            //access by index O(1)
            Console.WriteLine(array[0]);

            int length = array.Length;
            object elementNeeded = new object();

            //searching for an element takes O(n)
            for (int i = 0; i < length; i++)
            {
                if(array[i] == elementNeeded)
                {
                    Console.WriteLine("Found!");
                }
            }

            //add to a full array
            var bigArray = new int[length * 2];
            Array.Copy(array, bigArray,length);
            bigArray[length + 1] = 10;


            //add to the end of the array, when the array is not full O(1);
            array[length - 1] = 10;

            //When removing an element by it's index you just set it to null 
            //O(1)
            array[5] = null;






        }


        private static void RemoveAt(object[] array, int index)
        {
            //1,2,3,4,5
            //index 2
            //new array will be 1,2,3,5
            var newArray = new object[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);// 1,2,3
            Array.Copy(array, index + 1, newArray, index, array.Length - 1 - index);// 5

        }

        private static unsafe void IterateOver(int[] vs)
        {
           fixed(int* b = vs)
           {
                int* p = b;
                for (int i = 0; i < vs.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
           }
        }

        private static void ArraysDemo()
        {
            int[] a1;

            //arrays allways havve the length defined, and cannot be changed.
            //in order to change the length, we need to create a new array and copy the elements of the old array into the new one;
            a1 = new int[10];
            int[] a2 = new int[5];//Create and instantiate the array in one single line.
            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a4 = { 1, 2, 3, 4, 5 };
            //int[5] a5 = { 1, 2, 3, 4, 5, }; this is not correct!!


            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write($"{a3[i]}");
            }

            Console.WriteLine();

            foreach (var el in a4)
            {
                Console.Write($"{el}");
            }

            Console.ReadLine();

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(5, 0);

            Console.ReadLine();
        }

        private static void Test1BasedArray()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(101, 1);
            myArray.SetValue(102, 2);
            myArray.SetValue(103, 3);
            myArray.SetValue(104, 4);

            Console.WriteLine($"Starting index is: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index is: {myArray.GetUpperBound(0)}");


            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"Element at index {i} is {myArray.GetValue(i)}");
            }

            Console.ReadLine();

        }

        private static void MultiDimArrays()
        {
            int[,] d1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] d2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < d1.GetLength(0); i++)
            {
                for (int j = 0; j < d1.GetLength(1); j++)
                {
                    
                    Console.Write($"{d1[i, j]}");

                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        //Jagged arrays are multidemsion array that can have different number of collumns for each row
        private static void JaggedArrays()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Please fill in the array.");

            for (int i = 0; i < jaggedArray.Length; i++) //jaggedArray.length returns the number of ROWs that the array have
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) //this gets the length of the array from the specific row
                {
                    string input = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(input);
                }
            }


            Console.WriteLine("The Elements Are:");
            Console.WriteLine();

            for (int i = 0; i < jaggedArray.Length; i++) //jaggedArray.length returns the number of ROWs that the array have
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) //this gets the length of the array from the specific row
                {
                    Console.Write(jaggedArray[i][j]);
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }




    }
}
