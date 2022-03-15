namespace quicksort
{
    class Program
    {
        /* Fra geeksforgeeks eksempel */
        /* Sortere angivet array */
        static void Quicksort(int[] intArr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(intArr, low, high);

                Quicksort(intArr, low, pi - 1);
                Quicksort(intArr, pi + 1, high);
            }
        }

        /* Deler array op i bider, til sortering */
        static int Partition(int[] intArr, int low, int high)
        {
            int pivot = intArr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if(intArr[j] < pivot)
                {
                    i++;
                    (intArr[i], intArr[j]) = (intArr[j], intArr[i]);
                }
            }
            (intArr[i + 1], intArr[high]) = (intArr[high], intArr[i + 1]);
            return (i + 1);
        }


        /* Mit eget forsøg på en sorterings algoritme */
        static void SortArray(int[] intArr)
        {
            int mid = MidArray(intArr);
            int end = intArr.Length - 1;
            int start = 0;
            int indx = 1;

            Console.WriteLine("\n\nMiddle: " + intArr[mid]);

            for (int i = 0; i < intArr.Length; i++)
            {
                //if(intArr[start] > intArr[mid])
                //{
                //    Console.WriteLine("true");
                //    var temp = intArr[start];
                //    intArr[start] = intArr[mid];
                //    intArr[mid] = temp;
                //} else 

                if (intArr[i] > intArr[mid])
                {
                    (intArr[i], intArr[mid + 1]) = (intArr[mid + 1], intArr[i]);
                    //if (intArr[i] < intArr[end])
                    //{
                    //    (intArr[i], intArr[end - 1]) = (intArr[end - 1], intArr[i]);
                    //}
                }
                //else
                //{
                //    (intArr[i], intArr[mid - 1]) = (intArr[mid - 1], intArr[i]);
                //}
                //else if (intArr[i] > intArr[mid])
                //{
                //    (intArr[i], intArr[start]) = (intArr[start], intArr[i]);
                //}
            }            
        }

        static int MidArray(int[] intArr)
        {
            int mid = intArr.Length / 2;

            return mid;
        }
        static void Main()
        {
            int[] intArr = { 2,6,5,7,1 };

            Console.WriteLine("\nOriginal array: ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write($"{intArr[i]} ");
            }

            SortArray(intArr);

            //Quicksort(intArr, 0, intArr.Length - 1);

            Console.WriteLine("\n\nSorted array: ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write($"{intArr[i]} ");
            }

            

            Console.WriteLine("\n");
        }
    }
}   
