// See https://aka.ms/new-console-template for more information
using System.Collections;
using HomeWork17;
Console.WriteLine("Hello, World!");


MyList<int> lst = new MyList<int>();


lst.Add(1);
lst.Add(2);

//foreach (int i in lst)
//{
//    Console.WriteLine(i);
//}

Print(lst);
Console.WriteLine("/////////////////");

lst.AddRange(1, new int[] { 3, 4, 5, 6 });
Print(lst);
Console.WriteLine("//////////////////");

lst.Remove(1);
Print(lst);
Console.WriteLine("//////////////////");


lst.RemoveRange(2, 3);
Print(lst);
Console.WriteLine("//////////////////");


lst.Add(45);
lst.RemoveAt(0);
Print(lst);


Console.WriteLine(lst.Indexer(1));
//Console.WriteLine(lst.Indexer(3));
Console.WriteLine(lst.Count());

if (lst.Contains(1))
{
    Console.WriteLine("Yes, Contains");
}else
{
    Console.WriteLine("No, doesn't contain");
}



Print(lst);
Console.WriteLine("//////////////////");


int singleNumber =  lst.Single(n => n % 3 ==0);
Console.WriteLine("Single Number: "+singleNumber);
Console.WriteLine("//////////////////");

int singleOrdefaultNumber = lst.SingleOrDefault(n => n > 100);
Console.WriteLine("Single or Default Number: " + singleOrdefaultNumber);
Console.WriteLine("//////////////////");


int findElement = lst.Find(n => n > 1);
Console.WriteLine("Find Number > 1: " + findElement);
Console.WriteLine("//////////////////");

MyList<int> elements = new MyList<int>();
elements.AddRange(0,lst.Where(n => n > 1));
Print(elements);
Console.WriteLine("//////////////////");

elements.RemoveRange(0, elements.Count());
elements.AddRange(0, lst.Where(n => n < 1));
Print(elements);
Console.WriteLine("//////////////////");

void Print<T>(MyList<T> lst)
{
    foreach (T i in lst)
    {
        Console.WriteLine(i);
    }
}

Console.ReadLine();