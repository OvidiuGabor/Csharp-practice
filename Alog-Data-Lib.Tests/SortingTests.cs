using NUnit.Framework;
using Practice_algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alog_Data_Lib.Tests
{
    [TestFixture]
    public class SortingTests
    {

       private int[][] Samples()
       {
            int[][] samples = new int[9][];
            samples[0] = new[] {1};
            samples[1] = new[] {2,1};
            samples[2] = new[] {2,1,3};
            samples[3] = new[] {1,1,1};
            samples[4] = new[] {2,-1,3,3};
            samples[5] = new[] {4,-5,3,3};
            samples[6] = new[] {0,-5,3,3};
            samples[7] = new[] {0,-5,3,0};
            samples[8] = new[] {3,2,5,5,1,0,7,8};

            return samples;
        }
        private void RunTestsForSortAlgorith(Action<int[]> sort)
        {
            foreach(var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] arr)
        {
            TestContext.WriteLine("---------TRACE------\n");
            foreach(var el in arr)
            {
                TestContext.Write(el + " ");
            }

            TestContext.WriteLine("\n--------------------\n");
           
        }

        [Test]
        public void BubleSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(Sorting.BubbleSort);
        }

        [Test]
        public void SelectionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(Sorting.SelectionSort);
        }
        [Test]
        public void InsertionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(Sorting.InsertionSort);
        }

        [Test]
        public void ShellSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(Sorting.ShellSort);
        }

        [Test]
        public void MergeSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(Sorting.MergeSort);
        }
        [Test]
        public void QuickSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(Sorting.QuickSort);
        }


        //-----------------Implement the sorting algorithms on my oww

        [Test]
        public void PracticeBubleSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(PracticeSort.BubbleSort);
        }

        [Test]
        public void PracticeSelectionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(PracticeSort.SelectionSort);
        }

        [Test]
        public void PracticeSInsertionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorith(PracticeSort.InsertionSort);
        }

    }
}
