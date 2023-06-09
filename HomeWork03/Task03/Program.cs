using System;
using System.Linq;


Console.WriteLine("Enter the first array's lenght: ");
int len1 = int.Parse(Console.ReadLine());

int[] list1 = new int[len1];

for (int i = 0; i < len1; i++)
{
    Console.WriteLine("Enter the element: ");
    list1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter the second array's lenght: ");
int len2 = int.Parse(Console.ReadLine());

int[] list2 = new int[len2];
for (int i = 0;i < len2; i++)
{
    Console.WriteLine("Enter the element: ");
    list2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("enter the ASC or DESC");
string ans = Console.ReadLine();

int[] result = list1.Concat(list2).ToArray();

Array.Sort(result);

if (ans.ToLower() == "desc")
{
    Array.Reverse(result);
}

foreach (int item in result)
{
    Console.WriteLine(item.ToString());
}


Console.ReadLine();

