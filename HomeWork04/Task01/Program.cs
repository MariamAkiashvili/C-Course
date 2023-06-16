// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number of array elements");

int length = int.Parse(Console.ReadLine());
int[] arr = new int[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the element:");
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter the index of the element between 0 "+(arr.Length-1)+" : ");
int index = int.Parse(Console.ReadLine());
if (index >= arr.Length)
{
    Console.WriteLine("Index is out of array.");
}
else
{
    Console.WriteLine(SumOfDigits(arr, index));
}



int SumOfDigits(int[] arr, int index)
{
    int sum = 0;
    int number = arr[index];
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
