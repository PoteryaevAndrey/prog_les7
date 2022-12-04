/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

 

double[,] CreateRandom2dArrayDouble(int rows, int colums) // рандомное заполнение двумерного массива вещественными числами
{
    double[,] newArray = new double[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().NextDouble() * 100;
            
        }
    }

    return newArray;
}
void Show2dArrayDouble (double[,] array) // вывод двумерного массива
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write("{0,9:F2}", array[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArrayDouble(rows, colums);
Show2dArrayDouble(array); 
