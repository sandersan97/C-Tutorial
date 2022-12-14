using System;

//--------------------------------------------------------------------------------------------------------------------------------   Leason_1

/*Quest_1

Console.WriteLine("Enter your first number");
int numberA=int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number");
int numberB=int.Parse(Console.ReadLine());

if (numberA>numberB) 
{
int max=numberA;
int min=numberB;
Console.WriteLine("Max number is : "+ numberA +  " Min number is : " + numberB);
}
else
{
    if(numberA==numberB)
    {
      Console.WriteLine("Your numbers is equal");
    }
    else
    {
        int max=numberB;
        int min=numberA;
    Console.WriteLine("Max number is : "+ numberB +  " Min number is : " + numberA);
    }
} 
*/


/*Quest_2
Console.WriteLine("Enter your first number");
int numberA =int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number");
int numberB =int.Parse(Console.ReadLine());
Console.WriteLine("Enter your last number");
int numberC =int.Parse(Console.ReadLine());
int maxnumber=numberA;
if (numberA>numberB)
{
    if (numberA>numberC)
    {
        maxnumber=numberA;
    }
    else
    {
        maxnumber=numberC;
    }
}
else
{
    maxnumber=numberB;
    if (numberB>numberC)
    {
        maxnumber=numberB;
    }
    else
    {
        maxnumber=numberC;
    }
}

Console.WriteLine("Max number is: " + maxnumber);
*/

/*Quest_3
Console.WriteLine("Enter your number");
int numberA =int.Parse(Console.ReadLine());
if ((numberA % 2) == 0)
{
    Console.WriteLine("chetnoe");
}
else
{
    Console.WriteLine("nechetnoe");
}
*/

/*Quest_4
Console.WriteLine("Enter your number");
int numberA =int.Parse(Console.ReadLine());
for (int i = 1; i <= numberA; i++)
{
   if (i%2==0)
   {
    Console.WriteLine("--> " + i);
   }
}
*/

//--------------------------------------------------------------------------------------------------------------------------------   Leason_2

/*Leason_2(Quest_1)
Console.WriteLine("Enter your number with 3 characters");
int numberA =int.Parse(Console.ReadLine());
int SecondNumber=numberA/10%10;
Console.WriteLine("Your  second number  is: " + SecondNumber);
*/



/*Leason_2(Quest_2)
Console.WriteLine("Enter your number with 3 characters");
int numberA =int.Parse(Console.ReadLine());
if (numberA/1000%10>0)
{
    int SecondNumber=numberA/10%10;
Console.WriteLine("Your  second number  is: " + SecondNumber);
}
else
{
if (numberA/100%10>0)
{
int SecondNumber=numberA%10;
Console.WriteLine("Your  second number  is: " + SecondNumber);
}
else
{
    Console.WriteLine("Your number  is not normal from 3 characters");
}
}
*/



/*Leason_2(Quest_3)
Console.WriteLine("Enter your day number ");
int numberA =int.Parse(Console.ReadLine());
if (numberA>=6 & numberA<=7)
{
    Console.WriteLine("Its  weekend");
}
else
{
    Console.WriteLine("Its  not weekend");
}
*/




//--------------------------------------------------------------------------------------------------------------------------------   Leason_3

//Quest_1 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
 string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        
        reverse += cArray[i];
    }
    return reverse;
}

// Function to check if a given number is a palindrome or not
void isPalindrome(string number)
{
	if (Reverse(number)==number)
    {
        Console.WriteLine("Palindrome");
    }
    else
    {
        Console.WriteLine("Not Palindrome");
    }
}
Console.WriteLine("Enter your number");
string writednumber = Console.ReadLine();
isPalindrome(writednumber);
*/

//Quest_2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double GetDistance(double X1,double Y1,double Z1,double X2,double Y2,double Z2)
{
double distance = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
return(distance);

}
Console.WriteLine("Enter X1");
double numberA =double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y1");
double numberB =double.Parse(Console.ReadLine());
Console.WriteLine("Enter Z1");
double numberC =double.Parse(Console.ReadLine());
Console.WriteLine("Enter X2");
double numberD =double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y2");
double numberE =double.Parse(Console.ReadLine());
Console.WriteLine("Enter Z2");
double numberF =double.Parse(Console.ReadLine());

double Result=GetDistance(numberA,numberB,numberC,numberD,numberE,numberF);
Console.WriteLine("Your distance is:--> " + Result);
*/


//Quest_3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void CalculateCubs(double Count)
{
for (int i = 1; i <= Count; i++)
{
    double coub =i*i*i;
    Console.WriteLine(coub);
}
}
Console.WriteLine("Enter Your number");
double number =double.Parse(Console.ReadLine());
CalculateCubs(number);
*/



//--------------------------------------------------------------------------------------------------------------------------------   Leason_4

//Quest_1 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow


double CustomPow (double BaseNumber, double PowerNumber )
{
    double result=1;
    if (BaseNumber==0)
    {
        return(0);
    }
    if (PowerNumber<0)
    {
        double defactor=1;
        for (int i = 1; i <=PowerNumber*-1 ; i++)
        {
            result=result*BaseNumber;
            defactor=result;
        }
        result=1/defactor;
    }
    if (PowerNumber==0)
    {
        return(1);
    }
    if (PowerNumber>0)
    {
        result=BaseNumber;
        for (int i = 1; i <=PowerNumber-1 ; i++)
        {
            result=result*BaseNumber;
        }
    }
    return(result);
}
Console.WriteLine("Enter Your Base number");
double numberA =double.Parse(Console.ReadLine());
Console.WriteLine("Enter Your Power number");
double numberB =double.Parse(Console.ReadLine());
Console.WriteLine("Result:--> " + CustomPow(numberA,numberB));





//Quest_2 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int NumbersCountSum(int BaseNumber)
{
    int sum=0;
    if (BaseNumber<=0)
    {
        sum=-1;
    }
    while (BaseNumber > 0)
    {
        sum=sum+BaseNumber%10;
        BaseNumber=BaseNumber/10;

    }
return(sum);
}
Console.WriteLine("Enter Your Base number");
int numberA =int.Parse(Console.ReadLine());
Console.WriteLine("Result:--> " + NumbersCountSum(numberA));

*/



//Quest_3 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

int[] GenerateArray(int countA)
	{
		Random random = new Random();
		int[] values = new int[countA];
        
		for (int i = 0; i < countA; ++i)
        {
			values[i] = random.Next(0,10);
        
        }
		return (values);
	}

void PrintArray (int countB, int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < countB; ++i)
        {
            if (i==countB-1)
            {
                Console.Write(array[i] + " ]");
            }
            if (i<countB-1)
            {
                Console.Write(array[i] + ", ");
            }
        
        }
		return;
}
Console.WriteLine("Enter Your Array Length");
int numberA =int.Parse(Console.ReadLine());
Console.Write("Result:--> ");
PrintArray(numberA,GenerateArray(numberA));

*/
