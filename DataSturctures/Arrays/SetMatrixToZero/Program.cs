using System;
using System.Text;

namespace SetMatrixToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]{
                {0, 1, 2, 0},
                {3, 4, 5, 2},
                {1, 3, 1, 5}
            };
            Console.WriteLine("Input matrix: ");
            ShowMatrix(matrix);
            int[,] orderedMatrix = ReplaceMatrixToZero(matrix);
            Console.WriteLine("\nReplaced Matrix: ");
            ShowMatrix(orderedMatrix);
        }

        static int[,] ReplaceMatrixToZero(int[,] matrix){

            int mLength = matrix.GetLength(0), nLength = matrix.GetLength(1);

            int[] columns = new int[nLength], rows = new int[mLength];
            int counter = 0, i = 0;

            while (counter <= mLength - 1)
            {
                if (matrix[counter, i] == 0)
                {
                    columns[i] = 1;
                    rows[counter] = 1;
                }

                if (i == mLength)
                {
                    counter++;
                }

                if (i < mLength)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
            counter = 0; i = 0;
            while (counter < mLength)
            {
                if (columns[i] == 1 || rows[counter] == 1)
                {
                    matrix[counter, i] = 0;
                }

                if (i == mLength)
                {
                    counter++;
                }

                if (i < mLength)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }

            return matrix;
        }

        static void ShowMatrix(int[,] matrix){
            int mLength = matrix.GetLength(0), nLength = matrix.GetLength(1);
            for(int i = 0; i < mLength; i++){
                StringBuilder m = new StringBuilder();
                for(int j = 0; j < nLength; j++){
                    m = m.Append(matrix[i, j].ToString());
                    if(j < mLength){
                        m.Append(" | ");
                    }
                }
                Console.WriteLine(m.ToString());
            }
        }
    }
}
