//  Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.

const int ROWS = 3;
const int COLUMNS = 5;
int[,] FillMatrixRandom(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix);
Console.WriteLine();

int number = 0;
int compare = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    compare = compare + matrix[0, j];
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        sum = sum + matrix[i, j];

    }
    if (sum < compare)
    {
        compare = sum; number = i;
    }

}
Console.WriteLine($"Строка с наименьшей суммой элементов - {number + 1}-я");