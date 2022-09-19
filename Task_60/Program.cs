//  Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. Напишите программу, которая будет
//  построчно выводить массив, добавляя индексы каждого элемента.

const int ROWS = 2;
const int COLUMNS = 2;
const int DEPTH = 2;
HashSet<int> numbers = new HashSet<int>();
Random r = new Random();
int GenerateUniqueNumber()
{
    while (true)
    {
        int n = r.Next(10, 99);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

int[,,] FillMatrixRandom(int rows, int columns, int depth, int min = 10, int max = 99)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GenerateUniqueNumber();

            }
        }
        
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}

int[,,] matrix = FillMatrixRandom(ROWS, COLUMNS, DEPTH);
PrintMatrix(matrix);
Console.WriteLine();