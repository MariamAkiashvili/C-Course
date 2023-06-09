Console.WriteLine("Enter the number of height of the Pyramid: ");
int rows = int.Parse(Console.ReadLine());

string str;



if(rows > 0)
{
    for (int i = 1; i <= rows; i++)
    {
        str = "";
        for (int j = 0; j < rows - i; j++)
        {
            str += " ";
        }
        for (int j = 0; j < i*2 -1; j++)
        {
            str += "*";
        }
        for (int j = 0; j < rows - i; j++)
        {
            str += " ";
        }
        Console.WriteLine(str);

    }

}
else
{
    Console.WriteLine("Number of rows must be more than!");
}
