// See https://aka.ms/new-console-template for more information

char[] arr = Func1();

char elem;

while (true)
{
    Console.WriteLine("Enter the character you want to find in array: ");

    if (!char.TryParse(Console.ReadLine(), out elem))
    {
        Console.WriteLine("Please enter only one character!");
    }
    else
    {
        Func3(Func2(arr, elem), elem);
        break;
    }
}


char[] Func1()
{
    Console.WriteLine("Enter the number of array elements");
    int length = int.Parse(Console.ReadLine());
    char[] arr = new char[length];
    char val;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Enter the element:");
        if(char.TryParse(Console.ReadLine(), out val))
        {
            arr[i] = val;
        }
        else
        {
            Console.WriteLine("Please input only one character!");
            i--;
        }
        
    }

    return arr;
}

int Func2(char[] arr, char elem)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        num += arr[i] == elem ? 1 : 0;
    }
    return num;
}

void Func3 (int num, char elem)
{
    Console.WriteLine("'"+elem+"' occurs "+num+" times");
}
