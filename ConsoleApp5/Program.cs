using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsB, colsB, count0;
            int[,] matrixB;
            

            Console.WriteLine("Введите количество рядков и столбцов матрицы В через enter");
            rowsB = int.Parse(Console.ReadLine());
            colsB = int.Parse(Console.ReadLine());
            matrixB = new int[rowsB, colsB];
            int[][] matrixZ = new int[rowsB+1][];
            //Рандомно заполним матрицу В
            Random ran = new Random();
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    matrixB[i, j] = ran.Next(0, 2);
                }
            }
            //Выводим начения матрицы В на экран
            Console.WriteLine("Содержание матрицы В:");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write("{0,4}", matrixB[i, j]);
                }
                Console.WriteLine();
            }

            //Проходим матрицу В в поиске нулей и записываем их индексы в матрицу Z
            int[] P = new int[rowsB];
            for (int i = 0; i < rowsB; i++)
            {
                count0 = 0;
                
                for (int j = 0; j < colsB; j++)
                {
                    if (matrixB[i, j] == 0)
                    {
                        count0++;
                    }
                }
                matrixZ[i] = new int [count0];
                P[i] = count0;
                count0 =0;
                for (int l = 0; l < colsB; l++)
                {
                    if (matrixB[i, l] == 0)
                    {
                        matrixZ[i][count0]=l;
                        count0++;
                    }
                }
            }
            
            Console.WriteLine("Количество нулей в кождом рядке");
            foreach (int d in P)
            { Console.Write("{0,4}", d); }
            Console.WriteLine();

            Console.WriteLine("Новая матрица Z:");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < P[i]; j++)
                {
                    Console.Write("{0,4}", matrixZ[i][j]);
                }
                Console.WriteLine();
            }

            //Инвертируем матрицу Z с помощью библиотечных средств
            for (int i = 0; i < rowsB; i++)
            {
                Array.Reverse(matrixZ[i]);
            }

            Console.WriteLine("Інвертированная матрица Z:");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < P[i]; j++)
                {
                    Console.Write("{0,4}", matrixZ[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
