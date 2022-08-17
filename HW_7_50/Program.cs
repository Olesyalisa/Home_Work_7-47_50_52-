/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("massive size");
int oneM = int.Parse(Console.ReadLine());
int twoN = int.Parse(Console.ReadLine());
int[,] array = new int[oneM, twoN];
Random rnd = new Random();
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int s = 0; s < array.GetLength(1); s++)
    array [i, s] = rnd.Next(0,30);  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int s = 0; s < array.GetLength(1); s++)
    Console.Write(array[i,s] + "\t  ");
    Console.WriteLine();
}
 
 Console.WriteLine("coordinats massiva");
 int firstCoor = int.Parse(Console.ReadLine());
 int secondCoor = int.Parse(Console.ReadLine());
 if (firstCoor>oneM && secondCoor>twoN)
{
    Console.WriteLine("number false");
}
 
 else
 {
 object res = array.GetValue(firstCoor,secondCoor);
 Console.WriteLine(res);
 }