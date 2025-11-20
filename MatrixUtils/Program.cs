using System.ComponentModel;

namespace MatrixUtils
{
    class MatrixUtils
    { 
        public static void PrintMatrix(double[,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            for (int i = 0; i < rows; i++) 
            {
               for (int j = 0; j < cols; j++)
                    Console.Write($"\t{m[i, j]}");
                    Console.WriteLine();
            }
        }
        public static double[,] Add(double[,] A, double[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);
            if (rowsA != rowsB || colsA != colsB)
                throw new ArgumentException("Błędne rozmiary macierzy");
            var C = new double[rowsA, colsA];

            /*PrintMatrix(A);
            Console.WriteLine();
            
            PrintMatrix(B);
            Console.WriteLine();
            PrintMatrix(C);*/



            for (int i = 0; i < rowsA; i++)
            {
                //Console.WriteLine(i);
                for (int j = 0; j < colsA; j++)
                {
                    //Console.WriteLine(j);
                    C[i, j] = A[i, j] + B[i, j];
                }
            }



            return C;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A = {
                {1,2,3 },
                {4,5,6},
            };
            double[,] B = {
                {1,2,3 },
                {4,5,6},
            };
            MatrixUtils.PrintMatrix(MatrixUtils.Add(A,B));
        }
    }
}
