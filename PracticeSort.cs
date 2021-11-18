namespace Practice_algo
{
    public class PracticeSort
    {

        


        public static void InsertionSort(int[] arr) //2,1
        {
           
            for(int i = 1; i < arr.Length ; i++)
            {
                int curUnsorted = arr[i]; //1
                int partIndex = 0;
                for (partIndex = i; partIndex > 0 && arr[partIndex - 1] > curUnsorted; partIndex--)
                {
                    arr[partIndex] = arr[partIndex -1];
                }
                arr[partIndex] = curUnsorted;
            }
        }


        //With Selection sort, we have a temp var wherre we hold the index of the highest value, when we swap it with the element at the end of the array.
        //at the end we have a wall(tracker) that is moving to the front of the array, with evety new element that has been added to the end
        //it is sort of similar to the bubble sort
        public static void SelectionSort(int[] arr)
        {
           
            for(int wall = arr.Length -1; wall > 0; wall--)
            {
                int largetElement = 0;
                for (int i = 1; i <= wall; i++)
                {
                    if(arr[i] > arr[largetElement])
                    {
                        largetElement = i;
                    }
                }

                //if(arr[wall] < arr[largetElement])
                    Swap(arr, largetElement, wall);
            }
        }


        //the buble sort algo swaps the elements between each other and buble the biggest one to the end of the array, where there is a tracker
        //that is keeping tabs when the end has been reach and when a element reach the end, then the tracker is moving with 1 position to the front
        public static void BubbleSort(int[] arr)
        { 
            for (int wall = arr.Length -1; wall> 0; wall--)
            {
                for (int i =  0; i < wall; i++)
                {
                    if (arr[i] > arr[ i+1])
                        Swap(arr, i, i +1);
                }
            }
        }

        //Create a helper method for swapping elements in an arrray, since most of the sorting algorithms involves swapping the items
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
