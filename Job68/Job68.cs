/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumberM(string message) 
{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int numberM) && numberM >= 0)
        {
            digit = numberM;
            break;
        }
        else
        {
            Console.WriteLine($"{numberM} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

int GetNumberN(string message) 
{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int numberN) && numberN >= 0)
        {
            digit = numberN;
            break;
        }
        else
        {
            Console.WriteLine($"{numberN} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

int Akkerman (int numberM, int numberN)
{
    if(numberM == 0)
    {
        return numberN + 1;
    }
    else if(numberN == 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return Akkerman(numberM -1, Akkerman(numberM, numberN - 1));
    }
}

int numberM = GetNumberM("Введите натуральное число m: ");
int numberN = GetNumberN("Введите натуральное число n: ");
Console.WriteLine(Akkerman(numberM,numberN));
