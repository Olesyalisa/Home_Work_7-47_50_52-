/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Random rnd = new Random();
int oneM = rnd.Next(2, 5);
int twoN = rnd.Next(2, 5);

int[,] FillArray(int oneM, int twoN)
{
    int[,] arr = new int[oneM, twoN];
    Random rnd = new Random();

    for (int i = 0; arr.GetLength(0) > i; i++)
    {
        for (int s = 0; arr.GetLength(1) > s; s++)
        {
            arr[i, s] = rnd.Next(1, 30);
        }

    }
    return arr;
}

void GetMass(int[,] mas)
{
    Console.WriteLine();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int s = 0; s < mas.GetLength(1); s++)
        {
            Console.Write(mas[i, s] + "\t");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

int[,] arrMN = FillArray(oneM, twoN);
GetMass(arrMN);

double resSredArif = 0;

for (int i = 0; i < arrMN.GetLength(0); i++)
{
    for (int s = 0; s < arrMN.GetLength(1); s++)
    {
        resSredArif += arrMN[i, s];
       
    } 
    resSredArif /= arrMN.GetLength(0);
    Console.Write(string.Format("{0:F2}", resSredArif) + "; ");
}