
Random random = new Random();


while (true)
{
    Console.WriteLine("Enter the minimum: ");
    int min = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the maximum: ");
    int max = int.Parse(Console.ReadLine());

    int rand = random.Next(min, max + 1);

    Console.WriteLine("Let's try guess number: ");

    Console.WriteLine("Enter the number: ");
    int input = int.Parse(Console.ReadLine());

    int moves = 1;


    if (input == rand)
    {
        Console.WriteLine("You Won in 1 move");

    }
    else
    {

        while (rand != input)
        {
            Console.WriteLine("Incorrect Answer, try again: ");
            input = int.Parse(Console.ReadLine());
            moves++;
        }

        Console.WriteLine("You Won in " + moves + " moves");


    }
    Console.WriteLine("If you want to play again type 'Yes' otherwise 'No' :");

    string ans = Console.ReadLine();
    if (ans.ToLower() == "no")
    {
        break;
    }



}
Environment.Exit(0);
Console.ReadKey();

