double[,] FillMatrixByUser(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine($"\nВведите значение элемента [{i}, {j}]:");
            double.TryParse(Console.ReadLine(), out matrix[i, j]);
            Console.WriteLine();
        }
    }

    Console.WriteLine();
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void FindNumblerOfPositiveAndNegativeElements(double[,] matrix)
{
    int positiveCount = 0;
    int negativeCount = 0;
    int zerosCount = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0) positiveCount++;
            if (matrix[i, j] < 0) negativeCount++;
            if (matrix[i, j] == 0) zerosCount++;
        }
    }

    Console.WriteLine($"\n\t\tВ матрице содержится: \n{positiveCount} положительных чисел, \n{negativeCount} отрицательных чисел, \n{zerosCount} нулей\n"); ;
}

//double[,] InvertMatrix(double[,] matrix)
//{
//    var invertedMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

//    for (int i = 0; i < invertedMatrix.GetLength(0); i++ )
//    {
//        for (int j = 0; j < invertedMatrix.GetLength(1); j++)
//        {
//            if (matrix[i, j] == 0) invertedMatrix[i, j] = 0;              
//            else invertedMatrix[i, j] = Math.Round(1 / matrix[i, j], 3);  
//        }
//    }

//    return invertedMatrix;
//}

double[,] InvertMatrix(double[,] matrix)
{
    var invertedMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < invertedMatrix.GetLength(0); i++)
    {
        for (int j = invertedMatrix.GetLength(1) - 1, k = 0; j >= 0 && k < matrix.GetLength(1); j--, k++)
        {

            invertedMatrix[i, j] = matrix[i, k];

        }
    }

    return invertedMatrix;
}

double[,] SortArrayFromMostToLeast(double[,] matrix)
{
    var sortedMatrix = (double[,])matrix.Clone();

    for (int i = 0; i < sortedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sortedMatrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < sortedMatrix.GetLength(1) - j - 1; k++)
            {
                if (sortedMatrix[i, k] < sortedMatrix[i, k + 1])
                {
                    double temp = sortedMatrix[i, k];
                    sortedMatrix[i, k] = sortedMatrix[i, k + 1];
                    sortedMatrix[i, k + 1] = temp;
                }
            }
        }
    }

    return sortedMatrix;
}

double[,] SortArrayFromLeastToMost(double[,] matrix)
{
    var sortedMatrix = (double[,])matrix.Clone();

    for (int i = 0; i < sortedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sortedMatrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < sortedMatrix.GetLength(1) - j - 1; k++)
            {
                if (sortedMatrix[i, k] > sortedMatrix[i, k + 1])
                {
                    double temp = sortedMatrix[i, k];
                    sortedMatrix[i, k] = sortedMatrix[i, k + 1];
                    sortedMatrix[i, k + 1] = temp;
                }
            }
        }
    }

    return sortedMatrix;
}

Console.WriteLine("Введите количество строк массива: ");
int.TryParse(Console.ReadLine(), out int rows);
Console.WriteLine();

Console.WriteLine("Введите количество столбцов массива: ");
int.TryParse(Console.ReadLine(), out int cols);
Console.WriteLine();

var matrix = new double[rows, cols];
FillMatrixByUser(matrix);

bool continueOperations = true;

while (continueOperations)
{
    Console.WriteLine("\n**************************************************************************************");
    Console.WriteLine("\t\tЗаполненный массив:\n");
    PrintMatrix(matrix);
    Console.WriteLine("**************************************************************************************\n");

    Console.WriteLine("\nВыберете операцию над массивом: ");
    Console.WriteLine("1 - Найти количество положительных и отрицательных чисел");
    Console.WriteLine("2 - Построчная сортировка элементов от меньшего к большему");
    Console.WriteLine("3 - Построчная сортировка элементов от большего к меньшему");
    Console.WriteLine("4 - Построчная инверсия элементов матрицы\n");
    Console.WriteLine("(Введите любое другое значение для прекращения операций над матрицей)\n");

    string operation = Console.ReadLine();

    switch (operation)
    {
        case "1":
            FindNumblerOfPositiveAndNegativeElements(matrix);
            break;

        case "2":
            Console.WriteLine("\n\t\tCортировка строк матрицы от меньшего к большему: ");
            PrintMatrix(SortArrayFromLeastToMost(matrix));
            break;

        case "3":
            Console.WriteLine("\n\t\tCортировка строк матрицы от большего к меньшему: ");
            PrintMatrix(SortArrayFromMostToLeast(matrix));
            break;

        case "4":
            Console.WriteLine("\n\t\tИвертированная матрица: \n");
            PrintMatrix(InvertMatrix(matrix));
            break;

        default:
            // Console.WriteLine("Введенно некорректное значение операции");
            continueOperations = false;
            break;

    }
}



Console.ReadKey();

