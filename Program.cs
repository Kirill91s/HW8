﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// void Main()
// {
//     int row = ReadInt("Введите количество строк: ");
//     int col = ReadInt("Введите количество столбцов: ");
//     int[,] matrix = FillMatrix(row, col, 0, 100);
//     System.Console.WriteLine("Исходная матрица:");
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     System.Console.WriteLine("Матрица с сортировкой строк по убыванию:");
//     PrintMatrix(StreamLineMatrix(matrix, row, col));
// }


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] tempMatrix = new int[row, col];
//     Random rand = new Random();

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             tempMatrix[i, j] = rand.Next(leftRange, rightRange);
//         }
//     }
//     return tempMatrix;
// }


// void PrintMatrix(int[,] matrixToPrint)
// {
//     for (int i = 0; i < matrixToPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixToPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixToPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// int[,] StreamLineMatrix(int[,] matrix, int row, int col)
// {
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             for (int x = 0; x < col - j - 1; x++)
//             {
//                 if (matrix[i, x] < matrix[i, x + 1])
//                 {
//                     int temp = 0;
//                     temp = matrix[i, x];
//                     matrix[i, x] = matrix[i, x + 1];
//                     matrix[i, x + 1] = temp;
//                 }
//             }
//         }
//     }

//     return matrix;
// }


// Main();




﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void Main()
// {
//     int row = ReadInt("Введите количество строк: ");
//     int col = ReadInt("Введите количество столбцов: ");
//     System.Console.WriteLine();
//     int[,] matrix = FillMatrix(row, col, 0, 10);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();
//     int[] array = SumRou(matrix);
//     PrintArray(array);
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Минимальная сумма элементов находится на {MinPosition(array) + 1} строке");
// }


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] tempMatrix = new int[row, col];
//     Random rand = new Random();

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             tempMatrix[i, j] = rand.Next(leftRange, rightRange);
//         }
//     }
//     return tempMatrix;
// }


// void PrintMatrix(int[,] matrixToPrint)
// {
//     for (int i = 0; i < matrixToPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixToPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixToPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// int[] SumRou(int[,] matrix)
// {
//     int[] answer = new int[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             answer[i] += matrix[i, j];
//         }
//     }
//     return answer;
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine($"Сумма элементов каждой строки матрицы: [ {string.Join(", ", array)} ]");
// }


// int MinPosition(int[] array)
// {
//     int min = array[0];
//     int index = 0;
//     for (int i = 1; i <array.Length; i++)
//     {
//         if (min> array[i])
//         {
//             min = array[i];
//             index = i;
//         }
//     }
//     return index;
// }


// Main();











// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// void Main()
// {
//     System.Console.WriteLine("Сейчас, друг, тебе придётся ввести количество строк и столбцов для двух матриц для последующего их перемножения. Помни о том, чтобы произведение состоялось, необходимо чтобы количество строк первой матрицы совпадали с количеством столбцов второй и наоборот. Удачи!");
//     System.Console.WriteLine();
//     int row1 = ReadInt("Введите количество строк первой матрицы: ");
//     int col1 = ReadInt("Введите количество столбцов первой матрицы: ");
//     int row2 = ReadInt("Введите количество строк второй матрицы: ");
//     int col2 = ReadInt("Введите количество столбцов второй матрицы: ");

//     int[,] matrix1 = FillMatrix(row1, col1, 1, 5);
//     int[,] matrix2 = FillMatrix(row2, col2, 1, 5);

//     System.Console.WriteLine("Первая матрица:");
//     PrintMatrix(matrix1);
//     System.Console.WriteLine();
//     System.Console.WriteLine("Вторая матрица:");
//     PrintMatrix(matrix2);
//     System.Console.WriteLine();

//     if (matrix1.GetLength(0) != matrix2.GetLength(1))
//     {
//         System.Console.WriteLine("Ты ввёл такие значения строк и столбцов, что матрицы перемножить невозможно...");
//     }
//     else
//     {
//         int[,] newMatrix = MultiplicationMatrix(matrix1, matrix2);
//         System.Console.WriteLine("Результат перемножения матриц:");
//         PrintMatrix(newMatrix);
//     }
// }


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] tempMatrix = new int[row, col];
//     Random rand = new Random();

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             tempMatrix[i, j] = rand.Next(leftRange, rightRange);
//         }
//     }
//     return tempMatrix;
// }


// void PrintMatrix(int[,] matrixToPrint)
// {
//     for (int i = 0; i < matrixToPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixToPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixToPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] tempMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     {
//         for (int i = 0; i < matrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix2.GetLength(1); j++)
//             {
//                 for (int x = 0; x < matrix1.GetLength(1); x++)
//                 {
//                     tempMatrix[i, j] += matrix1[i, x] * matrix2[x, j];
//                 }
//             }
//         }

//     }
//     return tempMatrix;
// }


// Main();





﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// void Main()
// {
//     int row = ReadInt("Введите количество строк: ");
//     int col = ReadInt("Введите количество столбцов: ");
//     int dep = ReadInt("Введите количество чего-то там: ");

//     if (row <= 1 || col <= 1 || dep <= 1)
//     {
//         System.Console.WriteLine("По введённым параметрам массив не является трёхмерным.");
//     }
//     else if (row * col * dep > 90)
//     {
//         System.Console.WriteLine("При введённых аргументах создание трехмерного массива с неповторяющимися двузначных чисел невозможно.");
//     }
//     else
//     {
//         int[,,] matrix = new int[row, col, dep];
//         int count = 10;
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < col; j++)
//             {
//                 for (int k = 0; k < dep; k++)
//                 {
//                     matrix[i, j, k] = count;
//                     System.Console.Write($"\t{matrix[i, j, k]}, ({i} {j} {k})");
//                     count++;
//                 }
//                 System.Console.WriteLine();
//             }
//             System.Console.WriteLine();
//         }
//     }
// }


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Main();


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




// void Main()
// {
// int row = ReadInt("Введите количество строк: ");
// int col = ReadInt("Введите количество столбцов: ");
// PrintMatrix(Spiral(row, col));
// }


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[,] Spiral(int row, int col)
// {
// int[,] matrix = new int[row, col];
// int minRow = 0, maxRow = row - 1, minCol = 0, maxCol = col - 1;
// int count = 1;
// int max = row * col;
// while (count <= max)
// {
//     // if (count <= max) - вроде не надо
//     for (int i = minCol; i <= maxCol; i++)
//     {
//         matrix[minRow, i] = count;
//         count++;
//     }
//     minRow = minRow + 1;

//     // if (count <= max) - тоже не надо
//     for (int i = minRow; i <= maxRow; i++)
//     {
//         matrix[i, maxCol] = count;
//         count++;
//     }
//     maxCol = maxCol - 1;

//     if (count <= max)
//     for (int i = maxCol; i >= minCol; i--)
//     {
//         matrix[maxRow, i] = count;
//         count++;
//     }
//     maxRow = maxRow - 1;

//     if (count <= max)
//     for (int i = maxRow; i >= minRow; i--)
//     {
//         matrix[i, minCol] = count;
//         count++;
//     }
//     minCol = minCol + 1;
// }
// return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// Main();
