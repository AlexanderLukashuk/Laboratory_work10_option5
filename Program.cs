﻿using System;

namespace Tast10var5
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Отсортировать по убыванию элементов последнего столбца
            //* целочисленный двухмерный массив 5×4.

            int row = 5;
            int column = 4;
            int[,] numbersArray = new int[row, column];
            Random random = new Random();
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
            }

            //* Заполнить массив 3х3 числами по возрастанию, по спирали начиная с 
            //* центра. 
            //* 7 8 9
            //* 6 1 2
            //* 5 4 3


            //* Разработать программу, реализующую обработку числового двухмерного 
            //* произвольного массива тремя методами сортировки (пузырьком,
            //* вставкой, выбором).
        }
    }
}
