Console.WriteLine("Enter the length of string array: ");

int lenStr = int.Parse(Console.ReadLine());
string[] arrStr = new string[lenStr];

for (int i = 0; i < lenStr; i++)
{
    Console.WriteLine("Enter the Element");
    arrStr[i] = Console.ReadLine();
}

Console.WriteLine("Enter the lenght of int array: ");
int lenInt = int.Parse(Console.ReadLine());
int[] arrInt = new int[lenInt];

for (int i = 0; i<lenInt; i++)
{
    Console.WriteLine("Enter the Element");
    arrInt[i] = int.Parse(Console.ReadLine());
}

object[] objects = new object[lenInt+lenStr];


int small = lenStr > lenInt ? lenInt : lenStr;

for (int i= 1, j = 0; i < small*2; i+=2, j++)
{
    objects[i-1] = arrStr[j];
    objects[i] = arrInt[j];
    
}

for (int i = small*2, j = small; i <lenStr+lenInt; i++, j++)
{
    objects[i] = small == lenStr ? arrInt[j] : arrStr[j];
}

foreach (object obj in objects)
{
    Console.WriteLine(obj);
}


Console.ReadLine();


