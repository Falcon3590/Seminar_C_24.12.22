// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] arr) //  метод вывода массива на консоль
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
int GetSumOfRow(int[,] matrix, int i) // Метод считает сумму чисел в строке
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return (sum);
}

Console.Clear();

int[,] arr = new int[3, 5]; // задаю и генерирую прямоугольный массив 
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10, 99);
    }
}


Console.WriteLine("Вывод генерируемого массива:");
Console.WriteLine();
PrintArray(arr);

Console.WriteLine();

int sum = GetSumOfRow(arr, 0); // Инициализировал переменную и присвоил ей результат сложения первой строки (с индексом 0)
int num = 0;

for (int j = 0, y = 1; j < arr.GetLength(0); j++, y++) // Запускаю цикл сравнения. Результат сложения первой строки использую для запуска цикла сравнивая его с самим собой.
{
    int minimum = GetSumOfRow(arr, j);
    Console.WriteLine($"Результат сложения {y} строки = {minimum}"); // прорядок строк в обычном восприятии не по индексу =)
    if (sum > minimum)
    {
        sum = minimum;
        num = j;
    }
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {num + 1}"); // прорядок строк в обычном восприятии не по индексу =) если выводить по индексу +1 нужно убрать.
