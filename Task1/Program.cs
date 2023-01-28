// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
int[,] SetArray(int rows, int columns)  // Функция заполнения двухмерного массива с принятыми данными количества строк и стлобцов
{
    int[,] result = new int[rows, columns];  // выделяем место в памяти по количество строк и столбцов

    for (int i = 0; i < rows; i++)   // Цикл заполнения строк двухмерного массива
        for (int j = 0; j < columns; j++)  // Цикл заполнения столбцов двухмерного массива
            result[i, j] = i + j;   // Заполнение массива при помощи формулы Aₘₙ = m+n т.е. [0,0] = 0+0, [0,1] = 0+1, [0,2] = 0+2, [0,3] = 0+3, [1,0] = 1+0
        
    return result;  //возвращаем заполненный двухмерный массив 
}

void PrintArray(int[,] inArray)   //Функция распечатывания двухмерного массива
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

int rows = 3;        
int columns = 4;

int[,] array = SetArray(rows, columns);
PrintArray(array);



