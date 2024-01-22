namespace GA_MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            MergeSortArray(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }

        static void MergeSortArray(int[] arr)
        {
            // Step 1: Get the length of the array
            int arrayLength = arr.Length;

            // Step 2: Check if the array has 1 or 0 elements (base case)
            if (arrayLength <= 1)
            {
                Console.WriteLine("Base case reached: Array is already sorted or empty.");
                return;
            }

            // Step 3: Calculate the middle index of the array
            int middleIndex = arrayLength / 2;

            // Step 4: Create two subarrays, one for the left half and one for the right half
            int[] leftSubarray = new int[middleIndex];
            int[] rightSubarray = new int[arrayLength - middleIndex];

            // Step 5: Copy elements from the original array to the left and right subarrays
            for (int i = 0; i < middleIndex; i++)
            {
                leftSubarray[i] = arr[i];
            }
            for (int i = middleIndex; i < arrayLength; i++)
            {
                rightSubarray[i - middleIndex] = arr[i];
            }

            // Display the contents of left and right subarrays
            Console.WriteLine("Left Subarray:");
            PrintArray(leftSubarray);
            Console.WriteLine("Right Subarray:");
            PrintArray(rightSubarray);

            // Step 6: Recursively sort the left and right subarrays
            Console.WriteLine("Sorting left subarray:");
            MergeSortArray(leftSubarray);
            Console.WriteLine("Sorting right subarray:");
            MergeSortArray(rightSubarray);

            // Step 7: Merge the sorted left and right subarrays back into the original array
            Console.WriteLine("Merging sorted subarrays:");
            Merge(arr, leftSubarray, rightSubarray);
        }

        static void Merge(int[] arr, int[] leftSubarray, int[] rightSubarray)
        {
            int leftLength = leftSubarray.Length;
            int rightLength = rightSubarray.Length;
            int i = 0, j = 0, k = 0;

            // Step 8: Merge the left and right subarrays into the original array in sorted order
            while (i < leftLength && j < rightLength)
            {
                if (leftSubarray[i] <= rightSubarray[j])
                {
                    // Step 8a: If the element in the left subarray is smaller or equal, copy it to the original array
                    arr[k] = leftSubarray[i];
                    i++;
                }
                else
                {
                    // Step 8b: If the element in the right subarray is smaller, copy it to the original array
                    arr[k] = rightSubarray[j];
                    j++;
                }
                k++;
            }

            // Step 9: Copy any remaining elements from the left subarray (if any)
            while (i < leftLength)
            {
                arr[k] = leftSubarray[i];
                i++;
                k++;
            }

            // Step 10: Copy any remaining elements from the right subarray (if any)
            while (j < rightLength)
            {
                arr[k] = rightSubarray[j];
                j++;
                k++;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    } // class

} // namespace
