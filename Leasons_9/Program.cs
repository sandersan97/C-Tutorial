using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;



// Quest_1
/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/



Console.WriteLine("Enter your number.");
int enteredNumber=int.Parse(Console.ReadLine());

void FindRealNumbers(int baseNumber)
{
    int tempNumber=1;
    if (baseNumber<tempNumber)
    {
        return;
    }
    Console.Write($"{baseNumber},");
    baseNumber--;
    FindRealNumbers(baseNumber);
}
FindRealNumbers(enteredNumber);


// Quest_2
/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Enter your first number.");
int M=int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number.");
int N=int.Parse(Console.ReadLine());
int tempSum=0;

void SumRealNumbers(int baseNumber, int secondNumber)
{
    if (secondNumber != baseNumber)
    {
        if (secondNumber < baseNumber)
        {
            Console.Write($"{baseNumber},");
            tempSum=tempSum+baseNumber;
            baseNumber--;
            SumRealNumbers(baseNumber, secondNumber);
        }
        else
        {
            Console.Write($"{baseNumber},");
            tempSum=tempSum+baseNumber;
            baseNumber++;
            SumRealNumbers(baseNumber, secondNumber);
        }
    }
    else
    {
        Console.Write($"{baseNumber},");
        Console.Write($"[{tempSum+baseNumber}]");
        return;
    }
}
SumRealNumbers(M, N);




// Quest_3
/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/




Console.WriteLine("Enter your first number.");
int secondM=int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number.");
int secondN=int.Parse(Console.ReadLine());
int akermanResult=0;
int AkermanNumbers(int baseNumber, int secondNumber)
{
        if (baseNumber==0)
        {
            akermanResult=secondNumber+1;
            return akermanResult;
        }
        if (baseNumber>0 & secondNumber==0)
        {
            return(AkermanNumbers(baseNumber-1,1));
        }
        if (baseNumber>0 & secondNumber>0)
        {
            return(AkermanNumbers(baseNumber-1,AkermanNumbers(baseNumber,secondNumber-1)));
        }
        return(-1);
}
Console.WriteLine("Your Result is: --> " + "( " + AkermanNumbers(secondM, secondN) + " )");

