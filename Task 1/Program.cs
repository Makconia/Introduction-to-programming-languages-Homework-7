// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
 
int m = InputNumber("Введите значение М = ");
int n = InputNumber("Введите значение N = ");
System.Console.WriteLine();
RandArray(m, n);
System.Console.WriteLine();
 
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
 
void RandArray(int m, int n)
{
    double[,] arr = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 2);
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
