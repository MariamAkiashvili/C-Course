
//TASK02
Console.WriteLine("Enter The Number: ");

int input = int.Parse(Console.ReadLine());

int i = 1;

int seps = 1;
List <int> separators = new List<int>();
while (i <= input/2)
{

    if (input % i == 0)
    {
        separators.Add(i);
        seps++;
    }
    i++;
}
separators.Add(input);
Console.WriteLine(seps);
Console.WriteLine(string.Join(",",separators));
