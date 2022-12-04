//--------------------------------------------------------------------------------------------------------------------------------   Leason_1

//Quest_1

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