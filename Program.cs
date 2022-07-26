internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 54: Задайте двумерный массив. Напишите программу, 
        //которая упорядочит по убыванию элементы каждой строки двумерного массива.

        void Zadacha54()
        {
        Random random = new Random();
        int rows = random.Next(3, 7);
        int columns = random.Next(4, 8);
        int[,] array = new int[rows, columns];
        FillArray(array);
        Console.WriteLine("Вывод массива");
        PrintArray(array);
        Console.WriteLine("Вывод отсортированного по строкам массива");
        SortRows(array);
        PrintArray(array);

        }

        void FillArray(int[,] array)
        {
            Random random = new Random();
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j =0; j < columns; j++)
                {
                    array[i,j] = random.Next(-10, 10);
                }
            }
        }
        void PrintArray (int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j =0; j < columns; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        void SortRows (int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                    }
                }
                }
            }
        }

        //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
        //которая будет находить строку с наименьшей суммой элементов.

        void zadacha56()
        {
        Random random = new Random();
        int rows = random.Next(3, 5);
        int columns = random.Next(5, 9);
        int[,] array = new int[rows, columns];
        FillArray(array);
        Console.WriteLine("Вывод массива");
        PrintArray(array);
        LowSum(array);
  
        void LowSum(int [,] array)
        {
            int minSum = 0;
            int sumRow = sumRowElements(array, 0);

            for (int i = 1; i < array.GetLength(0); i++)
            {
                int tempsumRow = sumRowElements(array, i);
                if (sumRow > tempsumRow)
                {
                    sumRow = tempsumRow;
                    minSum = i;
                }
            }
            Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой элементов равной: ({sumRow}) ");
            int sumRowElements(int[,] array, int i)
            {
                int sumRow = array[i,0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    sumRow += array[i,j];
                }
                return sumRow;
            }

        }

        }


        //Задача 58. Заполните спирально массив 4 на 4.
        void zadacha58()
        {
            Random random = new Random();
            int[,] array = new int[4, 4];
            FillArray(array);
            checkArray(array);
            Console.WriteLine("Вывод массива");
            WriteSpiralArray(array);
            


            void checkArray(int[,] array)
            {
                int temp = 1;
                int i = 0;
                int j = 0;
                while (temp <= array.GetLength(0) * array.GetLength(1))
                {
                    array[i, j] = temp;
                    temp++;
                    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                        j++;
                    else if (i < j && i + j >= array.GetLength(0) - 1)
                        i++;
                    else if (i >= j && i + j > array.GetLength(1) - 1)
                        j--;
                    else
                        i--;
                }
            }
            
            void WriteSpiralArray (int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i,j] / 10 <= 0)
                        Console.Write($" {array[i,j]} ");

                        else Console.Write($"{array[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }


        //Zadacha54();
        //zadacha56();
        zadacha58();
    }
}