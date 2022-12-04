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