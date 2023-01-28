// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


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

int SumMainDiagArray(int [,] array) // Функция нахождения элементов на главной диагонали
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++) //Цикл проходит по строкам 
        sum += array[i, i];     // записываем сумму элементов на главно диоганали

    return sum;
}

void PrintArray(int[,] inArray) //Функция распечатывания двухмерного массива
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
Console.WriteLine($"Сумма на главной диагонали {SumMainDiagArray(array)}");
