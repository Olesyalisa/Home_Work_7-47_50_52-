/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
m = 3, n = 4. 
0,5 7 -2 -0,2 
1 -3,3 8 -9,9 
8 7,8 -7,1 9 */ 

double[,] randomArray = GetFillArray(3, 4); 
PrintArray(randomArray); 
 
double[,] GetFillArray(int oneM, int twoN)  
{  
    double[,] arr = new double[oneM, twoN];  
    Random rnd = new Random();  
    int max = 5; 
    int min = -5; 
    for (int i = 0; i < arr.GetLength(0); i++)  
    {  
        for (int s = 0; s < arr.GetLength(1); s++)  
        {  
            arr[i, s] = Math.Round(rnd.NextDouble() * (max -  min) + min, 1); 
        }  
  
    }  
    return arr;  
}  
void PrintArray(double[,] arr)  
{  
    for (int i = 0; i < arr.GetLength(0); i++)  
    {  
        for (int s = 0; s < arr.GetLength(1); s++)  
        {  
            Console.Write($"{arr[i, s]} " );  
        }  
        Console.WriteLine();  
    }  
}
