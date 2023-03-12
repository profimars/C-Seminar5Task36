// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//https://github.com/profimars/C-Seminar5Task36
void FillArray(int[] AA)
{
    Random rnd = new Random();
    for (int i = 0; i < AA.Length; i++)
        AA[i] = rnd.Next(-99, 100);
}

void PrintArray(int[] AA)
{
    foreach (int element in AA)
    {
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}

int Summ(int[] AA)
{
    int s = 0;
    for (int i = 0; i < AA.Length; i++)
    {
        if (i % 2 != 0)
            s = s + AA[i];
    }
    return s;
}

Console.WriteLine("Введите количество элементов в массиве а");
int a = Convert.ToInt32(Console.ReadLine());
int[] AA = new int[a];
FillArray(AA);
PrintArray(AA);
int rez = Summ(AA);
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях = " + rez);
