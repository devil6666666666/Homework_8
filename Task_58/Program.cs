// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Write("Введите количество столбцов первой матрицы и строк второй: ");
int columns1AndRows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
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
int[,] matrix1 = FillMatrixRandom(rows1, columns1AndRows2);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = FillMatrixRandom(columns1AndRows2, columns2);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] matrixResult = new int[rows1, columns2];
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        for (int k = 0; k < columns1AndRows2; k++)
        {
            matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}
PrintMatrix(matrixResult);