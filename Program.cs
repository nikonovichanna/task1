int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int numberC = new Random().Next(1,10);
Console.WriteLine(numberC);
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
else
    if (numberC > max)
    {
    max = numberC;
    }
System.Console.WriteLine(max);