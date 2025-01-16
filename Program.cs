using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();


        }
        static int[] CreateArray(int size, Random r)
        {
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = r.Next();
            }
            return nums;
        }
        static void menu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Linear Search");
            Console.WriteLine("2: Binary Search");
            Console.WriteLine("3: Bubble Sort");
            Console.WriteLine("3: Bubble Sort");
            Console.WriteLine("9: Quit");
            Console.WriteLine("-------------------------------------------");
        }
        
        static void BubbleSort(int[] a)
        {
            int temp;
            bool swaps;
            int count = 0;
            Stopwatch sw = new Stopwatch();
            do
            {
                swaps = false;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swaps = true;
                    }
                    count++;
                }
            } while (swaps);
            Console.WriteLine("the array is sorted");
            Console.WriteLine("it took " + count + " operations to do so");
            Console.WriteLine("it took " + sw.ElapsedMilliseconds + " milliseconds to do so");
            foreach (int i in a)
            {
                Console.Write(i + " ");

            }
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
            bool found = false;
            while (found)
            {
                int i = 0;
                if (a[i] == numToFind)
                {
                    found = true;
                }
                i++;
            }
            return found;
        }
        static bool BinarySearch(int[] a, int numToFind)
        {
            decimal Mid = 0;
            if((a.Length + 1) % 2 == 0)
            {
                Mid = (a.Length + 1) / 2;
            }
            else
            {
                Mid = (a.Length + 1) / 2;
                Mid = Math.Floor(Mid);
            }
            
            int upper = a.GetUpperBound(0);
            int lower = a.GetLowerBound(0);

            bool found = false;
            while (found)
            {
                if (Mid == numToFind)
                {
                    found = true; break;
                }
                else if (Mid < numToFind)
                {
                    upper = Decimal.ToInt32(Mid);
                    Mid = (upper + lower) / 2;
                    Mid = Math.Floor(Mid);
                }
                else if (Mid > numToFind)
                {
                    lower = Decimal.ToInt32(Mid);
                    Mid = (upper + lower) / 2;
                    Mid = Math.Floor(Mid);
                }
            }
            return found;
        }
            
    }
}
