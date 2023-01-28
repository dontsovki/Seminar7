// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue) // Функция заполнения массива рандомными числами, отдаёт заполненый массив result
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] SetSquareArray(int [,] array) // Функция перебора элементов с четными индексами, отдаёт массив из четных индексов array
{
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i += 2) // проверка индексов на чётность
            array[i, i] *= array[i, i];  // заменяем индексы элементов на их квадраты, перемножая индексы сами на себя

    return array; //возвращяем заполненный массив
}

void PrintArray(int[,] inArray)  //Функция распечатывания двухмерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int columns = 4;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

SetSquareArray(array);



//new Random().NextDouble()
