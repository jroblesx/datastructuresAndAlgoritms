using System;
using System.Collections.Generic;

namespace ChartIsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isUnique = IsUnique("jeaen"); //Must return False
            //bool isUnique = IsUnique("jean"); //Must return True
            Console.WriteLine($"Es unique: {isUnique}");
            Console.ReadLine();
        }

        //This solution is assuming the input is an ASCII string
        static bool IsUnique(string input)
        {
            if(input.Length > 128) return false;

            bool[] charSet = new bool[128]; 
            for(int i = 0; i < input.Length; i++){
                int charVal = input[i];
                if(charSet[charVal]) return false;
                charSet[charVal] = true;
            }
            return true;
        }
    }




}
