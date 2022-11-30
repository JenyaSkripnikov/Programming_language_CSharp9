/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
Например:
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumRec(int a, int b)
{
    if (a == b) return b;
    else return a+ SumRec(a+1,b);
}

Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumRec(a,b));
