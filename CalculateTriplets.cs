namespace Practice_algo
{
    public class CalculateTriplets
    {
        public static int Count(int[] input)
        {
            int n = input.Length;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1 ; j < n; j++)
                {
                    for (int k = j +1; k < n; k++)
                    {
                        if(input[i] + input[j] + input[k] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }
}
