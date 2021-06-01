using System;
using System.Text;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 2, 5, 1 };
            int[] result = ReverseArray(arr);
            Print(arr);
            Print(result);
            Console.ReadLine();
        }

        static void Print(int[] arr){
            StringBuilder sb = new StringBuilder(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if(i > 0){
                    sb.Append(" | ");
                }
                sb.Append(arr[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        static int[] ReverseArray(int[] arr){
            int arrL = arr.Length - 1;
            int[] arr2 = new int[arr.Length];
            for(int i = arrL; i >= 0; i--){
                arr2[arrL - i] = arr[i];
            }
            return arr2;
        }
    }
}
