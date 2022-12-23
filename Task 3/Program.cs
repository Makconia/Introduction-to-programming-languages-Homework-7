// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 
System.Console.WriteLine("Задайте размер массива:");
int y = InputNumber("Введите количество столбцов = ");
int x = InputNumber("Введите количество элементов в столбце = ");
System.Console.WriteLine();
int[,] array = RandArray(x, y);
System.Console.WriteLine();
ArithmeticAverage(array);
 
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
 
int[,] RandArray(int x, int y)
{
    int[,] arr = new int[x, y];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = rand.Next(-10, 10);
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    return arr;
}
 
void ArithmeticAverage(int[,] arr)
{
    double sum = 0;
    for (int y = 0; y < arr.GetLength(1); y++)
    {
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            sum += arr[x,y];
        }
        System.Console.WriteLine($"Среднее арифметическое элементов столбца № {y+1} = {Math.Round(sum/arr.GetLength(0), 2)},");
        sum = 0;
    }
}
