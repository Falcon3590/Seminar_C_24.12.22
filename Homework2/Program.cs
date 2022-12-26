// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] arr) //  метод вывода массива на консоль. Использую два раза.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int[,] arr = new int[3, 5];
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10, 99);
    }
}

Console.WriteLine();
Console.WriteLine("Вывод генерируемого массива:");
PrintArray(arr);
int sum = 0;

int GetSumOfRow(int[] matrix, int sum)
{
    for (int j = 0; j < arr.GetLength(1); j++){
        sum += matrix[j];
        }
    return(sum);
}

Console.WriteLine(GetSumOfRow(arr[,]));
