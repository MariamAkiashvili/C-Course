// See https://aka.ms/new-console-template for more information


//TASK01
Console.WriteLine("Enter The Number: ");

double input = double.Parse(Console.ReadLine());

int i = 2;

if (input == 1)
{
    Console.WriteLine("Neither Complex nor Simple");
}
else if (input == 2)
{
    Console.WriteLine("Simple");
}

int divs = 1;

while (i < input)
{

    if (input % i == 0)
    {
        input /= i;
        divs++;
    }
    else
    {
        i++;
    }
    if (divs >= 2)
    {
        Console.WriteLine("Number is Complex");
        break;
    }
}
if (divs < 2)
{
    Console.WriteLine("Number is Simple");
}