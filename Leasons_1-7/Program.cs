using System;
using System.Text;



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

/*
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

*/



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



//--------------------------------------------------------------------------------------------------------------------------------   Leason_5

//Quest_1 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] GenerateArray(int countA)
	{
		Random random = new Random();
		int[] values = new int[countA];
        
		for (int i = 0; i < countA; ++i)
        {
			values[i] = random.Next(100,1000);
        
        }
		return (values);
	}

int CalculateArray (int[] baseArray)
{
    int result=0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i]%2==0)
        {
            result++;
        }
    }
    return(result);
}
void PrintArray(int numbers,int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; ++i)
        {
            if (i==array.Length-1)
            {
                Console.Write(array[i] + " ]");
            }
            if (i<array.Length-1)
            {
                Console.Write(array[i] + ", ");
            }
        
        }
    Console.WriteLine("In your array is: --> " + numbers + " numbers.");
    
	return;
}
Console.WriteLine("Enter your array length ");
int numberA = int.Parse(Console.ReadLine());
int[] generatedArray = GenerateArray(numberA);
PrintArray(CalculateArray(generatedArray),generatedArray);

*/

//Quest_2 
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] GenerateArray(int countA)
	{
		Random random = new Random();
		int[] values = new int[countA];
        
		for (int i = 0; i < countA; ++i)
        {
			values[i] = random.Next(-1000,1000);
        
        }
		return (values);
	}

int CalculateArraySum (int[] baseArray)
{
    int result=0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (i%2>0)
        {
            result+=baseArray[i];
        }
    }
    return(result);
}

void PrintArray(int numbers,int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; ++i)
        {
            if (i==array.Length-1)
            {
                Console.Write(array[i] + " ]");
            }
            if (i<array.Length-1)
            {
                Console.Write(array[i] + ", ");
            }
        
        }
    Console.WriteLine("Sum of numbers is: --> " + numbers );
    
	return;
}

Console.WriteLine("Enter your array length ");
int numberA = int.Parse(Console.ReadLine());
int[] generatedArray = GenerateArray(numberA);
PrintArray(CalculateArraySum(generatedArray),generatedArray);
*/


//Quest_3 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

int[] GenerateArray(int countA)
{
    Random random = new Random();
    int[] values = new int[countA];

    for (int i = 0; i < countA; ++i)
    {
        values[i] = random.Next(Int32.MinValue, Int32.MaxValue);

    }
    return (values);
}

int FindMaxNumber(int[] array)
{
    int result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > result)
        {
            result = array[i];
        }
    }
    return (result);
}

int FindMinNumber(int[] array)
{
    int result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
        }
    }
    return (result);
}

int CalculateNumbers(int firstNumber, int secondNumber)
{
    int result = -1;
    if (firstNumber > secondNumber)
    {
        result = firstNumber - secondNumber;
    }
    if (firstNumber < secondNumber)
    {
        result = secondNumber - firstNumber;
    }
    if (firstNumber == secondNumber)
    {
        result = 0;
    }
    return (result);
}

Console.WriteLine("Enter your array length ");
int numberA = int.Parse(Console.ReadLine());
int[] generatedArray = GenerateArray(numberA);

void PrintArray(int[] array, int diference)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; ++i)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + " ]");
        }
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }

    }
    Console.WriteLine("\r");
    Console.WriteLine("Max number is: --> " + FindMaxNumber(generatedArray));
    Console.WriteLine("Min number is: --> " + FindMinNumber(generatedArray));
    Console.WriteLine("Diference between max and min number is: --> " + diference);

    return;
}

PrintArray(generatedArray, CalculateNumbers(FindMinNumber(generatedArray), FindMaxNumber(generatedArray)));

*/






//--------------------------------------------------------------------------------------------------------------------------------   Leason_6

//Quest_1 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

Console.Write("How much numbers you want enter? ");
int arrLength = int.Parse(Console.ReadLine());

int[] CreateArray(int arrayCount)
{
    int[] baseArray = new int[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        Console.Write($"Enter your {i} number: --> ");
        baseArray[i] = int.Parse(Console.ReadLine());
    }
    return (baseArray);
}

int CalculatePositiveNumbers(int[] calculableArray)
{
    int count = 0;
    for (int i = 0; i < calculableArray.Length; i++)
    {
        if (calculableArray[i] > 0)
        {
            count++;
        }
    }
    return(count);
}
 
 Console.WriteLine($"Numbers > 0 count is: --> {CalculatePositiveNumbers(CreateArray(arrLength))}"); // Можно для вывода сделать отдельный метод но у нас уже 2 есть и думаю нет необходимость.




//Quest_2 
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



double[] CrossPoint(double b1, double k1, double b2, double k2)
{
    double[] coordResult = new double[2];
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2) 
    {
        for (int i = 0; i < coordResult.Length; i++)
        {
            coordResult[i]=-1;
        }
        return(coordResult);
    }
    else
    {
        coordResult[0]= x;
        coordResult[1]= y;
        return(coordResult);
    }
}

bool CrossControll(double[]enteredArray)
{
    if (enteredArray[0]==-1 && enteredArray[1]==-1)
    {
        return(false);
    }
    else
    {
        return(true);
    }
}



void PrintCrossArray(double[] array)
{
    Console.Write("( ");
    for (int i = 0; i < array.Length; ++i)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + " )");
        }
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + "; ");
        }

    }
    return;
}





Console.WriteLine("Enter your first number:  ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your third number");
int numberC = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your fourth number");
int numberD = int.Parse(Console.ReadLine());

double[] pointsResult = CrossPoint(numberA,numberB,numberC,numberD);
if (CrossControll(pointsResult)==true)
{
    PrintCrossArray(pointsResult);
}

else
{
    Console.Write("Заданные прямые не пересекаются!");
}

*/




//--------------------------------------------------------------------------------------------------------------------------------   Leason_7


static double GetRandomDoubleRange(double lowerBound, double upperBound)
{
    var random = new Random();
    var rDouble = random.NextDouble();
    var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
    return rRangeDouble;
}



void SelectHomeworkLastLeson()
{
    Console.WriteLine("Please Select Quest number: 1 | 2 | 3 ");
    int QuestNumber = int.Parse(Console.ReadLine());

    int enteredRow = 3;
    int enteredColumn = 4;
    switch (QuestNumber)
    {
        case 1:
            Console.WriteLine("\n" + "-------------------------------> Quest_1 ");
            Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами." + "\n");
            PrintMatrix(CreateDoubleArray(enteredRow, enteredColumn, false));
            break;
        case 2:

            Console.WriteLine("\n" + "-------------------------------> Quest_2 ");
            Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," + "\n" + "и возвращает значение этого элемента или же указание, что такого элемента нет." + "\n");
            double[,] case2Array = CreateDoubleArray(3, 4, true);
            PrintMatrix(case2Array);
            Console.WriteLine("\n" + "Please enter your first index");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second index");
            int secondNumber = int.Parse(Console.ReadLine());
            FindElementContent(case2Array, firstNumber, secondNumber);
            break;
        case 3:
            Console.WriteLine("\n" + "-------------------------------> Quest_3 ");
            Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце." + "\n");
            double[,] case3Array = CreateDoubleArray(enteredRow, enteredColumn, true);
            PrintMatrix(case3Array);
            CalculateMediumArray(case3Array);
            break;
        default:
            Console.WriteLine("\n" + "!!! Sorry i dont have this Quest in my list !!! " + "\n");
            break;
    }
}
Console.OutputEncoding = Encoding.UTF8;
SelectHomeworkLastLeson();

//Quest_1 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateDoubleArray(int row, int column, bool realNumber)
{
    double[,] matrix = new double[row, column];
     var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (realNumber==true)
            {
                matrix[i, j] = rand.Next(0,10);
            }
            else
            {
                matrix[i, j] = GetRandomDoubleRange(-9,9);
            }
        }
    }
    return (matrix);
}
void PrintMatrix(double[,] enteredMatrix)
{
    for (int i = 0; i < enteredMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < enteredMatrix.GetLength(1); j++)
        {
            Console.Write(enteredMatrix[i, j] + "|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




//Quest_2 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


//Ther i will use created befor method from Quest_1.

(bool,double) FindElementContent(double[,]doubleArray,int firstIndex, int secondElement)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if (i==firstIndex && j==secondElement)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Your number in this index is: --> " + doubleArray[i,j] + "\n");
                return(i==firstIndex && j==secondElement,doubleArray[i,j]);
            }
        }
    }
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Can't find content on this index." + "\n");
    Console.WriteLine();
    return(false,-1);
}




//Without cycle.


(bool, double) FindElementContentWithoutCycle(double[,] doubleArray, int firstIndex, int secondIndex)
{

    if (doubleArray.GetLength(0) > firstIndex)
    {

        if (doubleArray.GetLength(1) > secondIndex)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Your number in this index is: --> " + doubleArray[firstIndex, secondIndex] + "\n");
            return (true, doubleArray[firstIndex, secondIndex]);
        }
        else
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Can't find content on this index." + "\n");
            Console.WriteLine();
            return (false, -1);
        }
    }
    else
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Can't find content on this index." + "\n");
        Console.WriteLine();
        return (false, -1);
    }
}





//Quest_3 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void CalculateMediumArray(double[,] matArray)
{
    double result = 0;
    for (int i = 0; i < matArray.GetLength(1); i++)
    {
        for (int j = 0; j < matArray.GetLength(0); j++)
        {
            result = result + matArray[j, i];
        }
        result = result / matArray.GetLength(0);
        Console.Write("( " + result + " )" + "\t");
        result = 0;
    }
}

