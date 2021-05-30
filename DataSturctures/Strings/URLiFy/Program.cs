using System;

namespace URLiFy
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = URLify("Je an");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //Solution: Two scan apporach
        static string URLify(string s){
            char[] input = s.ToCharArray();
            int trueLength = 5, spaces = 0, i = 0, index = 0;

            for(i = 0; i < trueLength; i++){
                if(input[i].Equals(' ')){
                    spaces++;
                }
            }
            index = trueLength + spaces * 2;
            for(i = trueLength - 1; i >= 0; i--){
                if(input[i].Equals(' ')){
                    input[index - 1] = '0';
                    input[index - 2] = '2';
                    input[index - 3] = '%';
                    index = index - 3;
                }else{
                    input[index - 1] = input[i];
                    index--;
                }
            }

            return new String(input);
        }
    }
}
