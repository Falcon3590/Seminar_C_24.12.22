// Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. Напишите программу, которая будет построчно выводить массив. Обратите внимание, что максимальный размер такого массива ограничен. Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
// Например,
// 11 22 78
// 12 47 96
// 25 87 88

// В задачах 3,4 необходимы разработка и использование функций. Без выполнения этого условия оценка будет снижаться.

bool СheckingForMatch(int n, int[,] arr) // Метод проверяет число на совпадение. Правда/Лож
{
    bool run = true;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (n == arr[i, j])
            {
                run = false;
                break;
            }

        }
    }
    return run;
}

void PrintArray(int[,] arr) //  метод вывода массива на консоль
{
    for (int i = 0, y = 0; i < arr.GetLength(0); i++, y++)
    {
        Console.WriteLine();
        Console.WriteLine($"Строка массива с индексом: {y}");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Random rnd = new Random();
int[,] arr = new int[9, 9]; // Массив ограничен 99 числвми, я использую 9 на 9 по сколько больше массивы (например 9 на 10 или 9 на 11 виснут)

for (int i = 0; i < arr.GetLength(0); i++) // Заполнение массива с проверкой числа на совподение (отправляю чисо в метод и получаю ответ)
{
    int j = 0;
    while (j < arr.GetLength(1)) 
    {

        int q = rnd.Next(10, 99);
        if (СheckingForMatch(q, arr) == true)
        {
            arr[i, j] = q;
            j++;
        }
    }
}

PrintArray(arr);