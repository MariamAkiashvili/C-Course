Console.WriteLine("Enter the number of inputs: ");
int numOfInputs = int.Parse(Console.ReadLine());

decimal sum = 0;
decimal mean = 0M;
for (int i = 0; i < numOfInputs; i++)
{
    Console.WriteLine("Enter the number: ");
    decimal input = decimal.Parse(Console.ReadLine());
    if(input >= 0)
    {
        sum += input;
    }
}

mean = sum/ numOfInputs;
Console.WriteLine("sum of number is " + sum);
Console.WriteLine("Mean of number is " + mean);

