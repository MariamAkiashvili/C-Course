// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter th elength of Array: ");

int lenght = int.Parse(Console.ReadLine());

int[] arr = new int[lenght];
for (int i = 0; i < lenght; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}


int[] news = new int[lenght]; 

List <int> list = new List <int>();
List <int> maxList = new List <int>();
list.Add(arr[0]);
int size = 1;

for (int i = 0;i < lenght-1; i++)
{
    if (arr[i] < arr[i+1])
    {
        list.Add(arr[i+1]);
        size++;
        Console.WriteLine("***");
        Console.WriteLine(i+1 +"    " + arr[i+1]);
        Console.WriteLine("***");
    }
    else
    {
        if (size > maxList.Count)
        {
            maxList = list;
            Console.WriteLine("*******");
        }
        size = 1;
        list.Clear();
        list.Add(arr[i + 1]);
    }
    
}


 if(list.Count > maxList.Count)
{
    maxList = list;
}


 foreach(int item in maxList)
{
    Console.WriteLine(item);
}


Console.ReadLine();

