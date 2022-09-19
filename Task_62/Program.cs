// Заполнить спирально массив 4 на 4.

int n = 4;
int[,] matrix = new int[n, n];
int i = 0, j = 0;
for (int temp = 1; temp <= matrix.GetLength(0) * matrix.GetLength(1); temp++)
{
    matrix[i, j] = temp;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
WriteArray(matrix);