using System;

namespace Tast10var5
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Отсортировать по убыванию элементов последнего столбца
            //* целочисленный двухмерный массив 5×4.

            Random random = new Random();
            /*int row = 5;
            int column = 4;
            int[,] numbersArray = new int[row, column];
            int temp;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    numbersArray[i, j] = random.Next(100);
                    Console.Write($"{numbersArray[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = i; j < row; j++)
                {
                    if (numbersArray[i, column - 1] < numbersArray[j, column - 1])
                    {
                        for (int k = 0; k < column; k++)
                        {
                            temp = numbersArray[i, k];
                            numbersArray[i, k] = numbersArray[j, k];
                            numbersArray[j, k] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{numbersArray[i, j]} ");
                }
                Console.WriteLine();
            }*/

            //* Заполнить массив 3х3 числами по возрастанию, по спирали начиная с 
            //* центра. 
            //* 7 8 9
            //* 6 1 2
            //* 5 4 3


            int arraySize = 3;
            int a = arraySize - 1;
            int b = arraySize;
            int c = -1;
            int d = 9;
            int[,] spiralArray = new int[arraySize, arraySize];
            for (int i = a; i >= 0; c *= -1)
            {
                for (int j = i; j >= 0; --j)
                {
                    spiralArray[a, b += c] = d--;
                }
                for (int j = --i; j >= 0; --j)
                {
                    spiralArray[a += c, b] = d--;
                }
            }

            for (int i = arraySize - 1; i >= 0; i--)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write($"{spiralArray[i, j]} ");
                }
                Console.WriteLine();
            }


            //* Разработать программу, реализующую обработку числового двухмерного 
            //* произвольного массива тремя методами сортировки (пузырьком,
            //* вставкой, выбором).

            int sizeArray = 5;
            int[,] array = new int[sizeArray, sizeArray];
            int tempElem;

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    array[i, j] = random.Next(100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Сортировка пузырьком
            for (int j = 0; j < sizeArray; j++)
            {
                bool sorted = false;
                while (!sorted)
                {
                    sorted = true;
                    for (int i = 0; i < sizeArray - 1; i++)
                    {
                        if (array[i, j] > array[i + 1, j])
                        {
                            tempElem = array[i, j];
                            array[i, j] = array[i + 1, j];
                            array[i + 1, j] = tempElem;
                            sorted = false;
                        }
                    }
                }
            }


            // метод выбора
            int tmp;
            int pos;
            for (int i = 0; i < sizeArray; ++i)
            {
                for (int j = 0; j < sizeArray; ++j)
                {
                    pos = j;
                    tmp = array[i, j];
                    for (int h = j + 1; h < sizeArray; ++h)
                    {
                        if (array[i, h] < tmp)
                        {
                            pos = h;
                            tmp = array[i, h];
                        }
                    }
                    array[i, pos] = array[i, j];
                    array[i, j] = tmp;
                }
            }

            // метод вставки
            int pos1;
            int tmp1;
            for (int i = 0; i < sizeArray; ++i)
            {
                for (int j1 = 0; j1 < sizeArray; ++j1)
                {
                    pos1 = j1;
                    tmp1 = array[i, pos1];
                    for (int j = j1 + 1; j < sizeArray; ++j)
                    {
                        if (array[i, j] < tmp1)
                        {
                            pos1 = j;
                            tmp1 = array[i, j];
                        }
                    }

                    array[i, pos1] = array[i, j1];
                    array[i, j1] = tmp1;
                }
            }

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
