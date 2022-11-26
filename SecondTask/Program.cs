// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


const int m = 4;
const int n = 4;
int [,] matrix = new int [m, n];
int[] array = new int [m];
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++) 
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++) 
{
    int sum = 0;
    for (int j = 0; j < n; j++) 
    {
        sum += matrix[i,j];
    }
    array[i] = sum;
}
int min = array[0];
int line = 0;
for (int i = 1; i < m; i++) 
{
    if (array[i] < min) 
    {
        min = array[i];
        line = i;
    }
}
Console.WriteLine($"{line + 1} строка с наименьшей суммой элементов, равная {min}");