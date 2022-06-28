// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//ВОПРОС - МОЖНО ЛИ ЧЕРЕЗ WRITELINE ВЫВЕСТИ ЭЛЕМЕНТЫ МАССИВА В ФОРМАТЕ С ДВУМЯ ЗНАКАМИ ПОСЛЕ ЗАПЯТОЙ?
//СПЕЦИАЛЬНО ДЛЯ ЭТОГО ПИШУ ОТДЕЛЬНЫЙ МЕТОД PTINT ARRAY, Т.К. ЧЕРЕЗ WRITE LINE НЕ ПОЛУЧАЕТСЯ

using System;
using static System.Console;

Clear();

WriteLine("Please type number rows and columns with a space: ");
string[] rowColumn = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int row = int.Parse(rowColumn[0]);
int column = int.Parse(rowColumn[1]);

double[,] myArray = GetRandomArray(row, column);
PrintArray(myArray);

double[,] GetRandomArray(int rows, int columns)
{
    double[,] result = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-10,10) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j].ToString("F2")} ");
        }
        WriteLine();
    }
}