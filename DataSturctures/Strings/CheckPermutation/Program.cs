using System;
using System.Linq;

namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool result = CheckPermutation("roma", "amor"); //Must return true
            //bool result = CheckPermutation("rama", "amor"); //Must return false
            bool result = CheckPermutation("roma", "aroma"); //Must return false
            Console.WriteLine($"Is permutable: {result}");
            Console.ReadLine();
        }

        static bool CheckPermutation(string input1, string input2){
            if(!input1.Length.Equals(input2.Length)) return false;

            input1 = new String(input1.OrderBy(x => x).ToArray());
            input2 = new String(input2.OrderBy(x => x).ToArray());

            if(input1 == input2) return true;

            return false;
        }
    }
}
