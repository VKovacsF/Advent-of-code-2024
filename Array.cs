using System;

int[] numbers = {10, 20, 30, 40, 50};
for (int i = 0; i < numbers.Length; i++) 
{
 Console.WriteLine(numbers[i]); 
}

int[] numbers = {10, 20, 30, 40, 50};
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
 sum += numbers[i]; 
}
Console.WriteLine("Total sum: " + sum);

int[,] matrix = { {1, 2, 3}, {4, 5, 6} };
for (int i = 0; i < 2; i++) 
{
 for (int j = 0; j < 3; j++) 
 {
 Console.Write(matrix[i, j] + " "); 
 }
 Console.WriteLine(); 
}


Console.ReadLine{};