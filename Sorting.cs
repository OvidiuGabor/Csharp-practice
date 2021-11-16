using System;

namespace Practice_algo
{
    public class Sorting {


        public static void QuickSort(int[] arr)
        {
            Sort(0, arr.Length - 1);

            void Sort(int low, int high){
                if (high <= low)
                    return;
                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);

            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;
                int pivot = arr[low];
                while(true)
                {
                    while(arr[++i] < pivot)
                    {
                        if(i == high)
                        {
                            break;
                        }
                    }
                    while(pivot < arr[--j])
                    {
                        if (j == low)
                            break;
                    }
                    if (i >= j)
                        break;

                    Swap(arr, i, j);
                }
                Swap(arr, low, j);

                return j;
            }
        }

        public static void MergeSort(int[] arr)
        {
            int[] aux = new int[arr.Length];
            Sort(0, arr.Length - 1);
            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }
            void Merge(int low, int mid, int high)
            {

                //if (arr[mid] <= arr[mid + 1])
                //    return;


                int i = low;
                int j = mid + 1;
                Array.Copy(arr, low, aux, low, high - low + 1);
                for(int k = low; k <= high; k++)
                {
                    if (i > mid) arr[k] = aux[j++];
                    else if (j > high) arr[k] = aux[i++];
                    else if (aux[j] < aux[i])
                        arr[k] = aux[j++];
                    else
                        arr[k] = aux[i++];
                }

            }
        }

        public static void BubbleSort(int[] arr)
        {
            for (int wall = arr.Length - 1; wall > 0; wall--)
            {
                for (int i = 0; i < wall; i++)
                {
                    if (arr[i] > arr[i + 1])
                        Swap(arr, i, i + 1);
                }
            }
        }

        public static void ShellSort(int[] arr)
        {
            int gap = 1;
            while (gap < arr.Length / 3)
            {
                gap = 3 * gap + 1;
            }
            while( gap >= 1)
            {

                for (int i = gap; i < arr.Length; i++)
                {
                    for (int j = i; j >=gap && arr[j] < arr[j -gap]; j-=gap)
                    {
                        Swap(arr, j, j - gap);
                    }
                }

                gap /= 3;
            }


        }

        public static void SelectionSort(int[] arr)
        {
            for (int  wall = arr.Length -1;  wall > 0; wall--)
            {
                int largestAt = 0;
                for (int i = 1; i <= wall; i++)
                {
                    if (arr[i] > arr[largestAt]) {
                        largestAt = i;
                    }
                }
                Swap(arr, largestAt, wall);
            }
        }

        //8,5,9,2
        //step 1: 8>5? true, 5,8,9,2
        //step 2: 8 > 9? false/ no shiftig
        //step 3: 9> 2 true, 5,8,2
        //step 4: 8 > 2 true, 
        public static void InsertionSort(int[] arr)
        {
            for (int wall = 1; wall < arr.Length; wall++)
            {
                int curUnsorted = arr[wall]; //2
                int i = 0;
                for (i = wall; i > 0 && arr[i -1] > curUnsorted ; i--) // 9 >2
                {
                    arr[i] = arr[i - 1];//2 => 9 => 5,8,9,9, i = 2/ 
                    //i = 2/ 8 > 2, 5,8,8,9
                    //i = 1/ 5 > 2, 5,5,8,9
                    //i = 0/ exit loop
                    
                   
                }
                arr[i] = curUnsorted;//2,5,8,9
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            if (i == j)
                return;

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
    }
}
