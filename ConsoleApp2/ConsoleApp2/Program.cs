using System;

namespace ConsoleApp2
{
    class Program
    {
       


            static int getOddOccurrence(int[] arr, int arr_size)
            {
                for (int i = 0; i < arr_size; i++)
                {
                    int count = 0;

                    for (int j = 0; j < arr_size; j++)
                    {
                        if (arr[i] == arr[j])
                            count++;
                    }
                    if (count % 2 != 0)
                        return arr[i];
                }
                return -1;
            }

             static void Main()
            {
                int[] arr = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
                int n = arr.Length;
                Console.Write(getOddOccurrence(arr, n));
            }



        
    }
}
