using System;
using System.Linq;

namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool result = CheckPermutation("roma", "amor"); //Must return true
            // bool result = CheckPermutation("rama", "amor"); //Must return false
            // bool result = CheckPermutation("roma", "aroma"); //Must return false

            bool result = CheckPermutationCounting("roma", "amor"); //Must return true
            // bool result = CheckPermutationCounting("rama", "amor"); //Must return false
            // bool result = CheckPermutationCounting("roma", "aroma"); //Must return false
            Console.WriteLine($"Is permutable: {result}");
            Console.ReadLine();
        }
        
        /*Solution 1: Sort both string, this will be ok only if we don't need to check case sensitive and if we could not have white spaces, so "jea n" is different to "jean" */
        static bool CheckPermutation(string input1, string input2){
            if(!input1.Length.Equals(input2.Length)) return false;

            input1 = new String(input1.OrderBy(x => x).ToArray());
            input2 = new String(input2.OrderBy(x => x).ToArray());

            if(input1 == input2) return true;

            return false;
        }

        /*Solution 2: Check if our inputs have identical character count*/
        static bool CheckPermutationCounting(string input1, string input2) {
            if(!input1.Length.Equals(input2.Length)) return false;

            int[] letters = new int[128]; //Assuming we have an ASCII input strings

            char[] input1Array = input1.ToArray();
            for(int pointer = 0; pointer < input1Array.Length; pointer++){
                letters[(int)input1Array[pointer]]++; //Count number of each character in input1
            }

            for(int i = 0; i < input2.Length; i++){
                int c = (int)input2[i];

                letters[c]--;

                if(letters[c] < 0){
                    return false;
                }
            }

            return true;
        }
    }
}
