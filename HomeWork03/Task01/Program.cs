// See https://aka.ms/new-console-template for more information



Console.WriteLine("Enter the lenght of array: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];
for (int i = 0; i< length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}


for (int j = 0; j < length; j+=2)
{

    for (int i = 1; i < length; i++)
    {

        if (array[i - 1] > array[i])
        {
            int x = array[i - 1];
            array[i - 1] = array[i];
            array[i] = x;
        }
    }
}


foreach(int i in array)
{
    Console.WriteLine(i);
}

Console.ReadLine();



