using System;
using System.IO;

int[,] matrix = new int[3, 3];


string[] lines = int.Parse(File.ReadAllLines(matrix));

for (int i = 0; i < lines.Length; i++)
{
    string[] values = lines[i].Split(',');
    for (int j = 0; j < values.Length; j++)
    {
        matrix[i, j] = int.Parse(values[j]);
    }
}

Console.WriteLine("The contents of the matrix are:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();