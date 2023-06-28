using System.Data.SqlTypes;
using Task11;

public class Program
{
    public static void Main(string[] args)
    {

        //Task1

        Console.WriteLine("********** Task 1 **********");
        Console.WriteLine();
        Numerics numeric1 = new Numerics();

        Console.WriteLine(numeric1.Add(5, 8));
        Console.WriteLine(numeric1.Subtract(12, 90));
        Console.WriteLine(numeric1.Multiply(2, 5));

        Console.WriteLine();
        Numerics numeric2 = new Numerics();

        Console.WriteLine(numeric2.Add(5.9, 8.3));
        Console.WriteLine(numeric2.Subtract(12.00, 9.8));
        Console.WriteLine(numeric2.Multiply(2, 5.4));
        Console.WriteLine();

        Numerics numeric3 = new Numerics();
        //Class1<string> class4 = new Class1<string>();

        //Console.WriteLine(class3.Add("Hello ", "World"));
        Console.WriteLine(numeric3.Subtract(12.00, 9.8));
        Console.WriteLine(numeric3.Multiply(2, 5.4));
        Console.WriteLine();


        Text text1 = new Text();
        Console.WriteLine(text1.Add("Hello ", "World"));
        Console.WriteLine(text1.Subtract("Hello world", "world"));
        Console.WriteLine(text1.Multiply("Hello", "3"));
        Console.WriteLine(text1.Multiply("Hello ", "asd"));





        //Task2
        Console.WriteLine("********** Task 2 **********");
        Console.WriteLine();   
        Storage <object> storage = new Storage<object>();
        storage.Add(100);
        storage.Add("White");
        storage.Add(11.23);

        storage.PrintAll();
        Console.WriteLine();

        storage.Delete(100);

        storage.PrintAll();
        Console.WriteLine();

        storage.Update(100, "Blue");

        storage.PrintAll();
        Console.WriteLine();

        storage.Update("White", "Blue");

        storage.PrintAll();
        Console.WriteLine();

        Console.ReadLine();
    }
}