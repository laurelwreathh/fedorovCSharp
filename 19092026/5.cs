int[,] matrix = new int[3, 3];

Console.WriteLine("Enter matrix elements:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Element [" + i + "," + j + "]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

int[,] newMatrix = new int[3, 3];


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        newMatrix[j, i] = matrix[i, j];
    }
}


Console.WriteLine("New matrix:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(newMatrix[i, j] + " ");
    }

    Console.WriteLine();
}