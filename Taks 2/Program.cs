// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
 
System.Console.WriteLine("Задайте размер массива:");
int m = InputNumber("Введите количество строк = ");
int n = InputNumber("Введите количество столбцов = ");
System.Console.WriteLine();
int[,] array = RandArray(m, n);
System.Console.WriteLine();
int index1 = InputNumber("Введите строку элемента: ");
int index2 = InputNumber("Введите столбец элемента: ");
NumberPosition(array, index1, index2);


 
int InputNumber(string str)
{
    int number;
    string text;
 
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}


 
int[,] RandArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(-10, 10);
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    return arr;
}


 
int NumberPosition(int[,] arr, int index1, int index2)
{
    int num = 0;
        if (index1 > arr.GetLength(0) || index2 > arr.GetLength(1) || index1 < 0 || index2 < 0)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        num = arr[index1 -1, index2 -1];
        System.Console.WriteLine($"Элемент [{index1},{index2}] имеет значение {num}");
    }
    return num;
}
