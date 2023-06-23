// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Task09;

Console.WriteLine("Hello");
Console.WriteLine("I want to introduce you our car catalog");
Console.WriteLine();


List<string> combats = new List<string>
{
    "Tyger |",
    "Panther Mark V",
    "Renault R35"
};

List<string> consumings = new List<string>
{
    "Jeep",
    "Bike",
    "Motorcycle",
    "Sedan"
};

List<string> publics = new List<string>
{
    "Bus",
    "Tram",
    "Subway"
};

List<string> sports = new List<string>
{
    "Formula",
    "Motorcycle",
    "OffRoad"
};



List <Vehicle> combatsLst = new List<Vehicle>();
List <Vehicle> consumingsLst = new List<Vehicle>();
List <Vehicle> publicLst = new List<Vehicle>();
List <Vehicle> sportLst = new List<Vehicle>();


for (int i = 0;i < combats.Count; i++)
{
    Combat combat1 = new Combat();
    combat1.Name = combats[i];
    combatsLst.Add(combat1);
}
for (int i = 0; i < consumings.Count; i++)
{
    Consuming consuming = new Consuming();
    consuming.Name = consumings[i];
    consumingsLst.Add(consuming);
}
for (int i = 0; i < publics.Count; i++)
{
    Public public1 = new Public();
    public1.Name = publics[i];
    publicLst.Add(public1);
}
for (int i = 0; i < sports.Count; i++)
{
    Sport sport = new Sport();
    sport.Name = sports[i];
    sportLst.Add(sport);
}

//Show Car List ordered by categories

Show.GetMembers(Category.Combat, combatsLst);
Show.GetMembers(Category.Consuming, consumingsLst);
Show.GetMembers(Category.Public, publicLst);
Show.GetMembers(Category.Sport, sportLst);


//Select Category
int categoryId;

Console.WriteLine();




while (true)
{
    Console.WriteLine("Choose category by Id number : ");
    foreach (Category cat in Enum.GetValues(typeof(Category)))
    {
        Console.WriteLine(cat + " ID - " + (int)cat);
    }
    string input = Console.ReadLine();
    if(input == "")
    {
        Console.WriteLine("Please choose any category");
        continue;
    }
    if (int.TryParse(input, out categoryId))
    {
        if (categoryId < 1 || categoryId > 4)
        {
            Console.WriteLine("Please choose valid ID");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Please enter only digits");
        continue;
    }
    break;
}

//Console.WriteLine(categoryId);

Console.WriteLine();

//Show Selected Category;

Category category = (Category)Enum.ToObject(typeof(Category), categoryId);
Console.WriteLine("You have chosen " + category.ToString());
Console.WriteLine("Let's select any from " + category.ToString());


// Select car;
int carId;

while (true)
{
    bool stop = true;

    Console.WriteLine("Choose car by Id");
    Console.WriteLine("You can choose car from the next list: ");

    switch (categoryId)
    {
        case 1:
            Show.GetMembers(combatsLst);
            break;
        case 2:
            Show.GetMembers(consumingsLst);
            break;
        case 3:
            Show.GetMembers(publicLst);
            break;
        case 4:
            Show.GetMembers(sportLst);
            break;
        default:
            break;

    }

    var input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("Please Choose Car Id");
        continue;
    }
    if(int.TryParse(input, out carId))
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter only digits");
        continue;
    }
}

// Show selected Car;

Console.Write("You have selected ");


switch (categoryId)
{
    case 1:

        Console.WriteLine(combatsLst[carId].Name);
        break;
    case 2:

        Console.WriteLine(consumingsLst[carId].Name);
        break;
    case 3:
        Console.WriteLine(publicLst[carId].Name);
        break;
    case 4:
        Console.WriteLine(sportLst[carId].Name);
        break;
    default:
        break;

}


//// change Speed



while (true)
{
    //var car;
    int speed;
    Console.WriteLine("How many times you want to improve your cars speed: ");
    var input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("please enter number");
        continue;
    }
    if (int.TryParse(input, out speed))
    {
        if (speed > 0)
        {

            //car.ChangeSpeed(speed);
            break;
        }
        else
        {
            Console.WriteLine("Please enter only natural number");
        }

    }
    else
    {
        Console.WriteLine("Please enter only natural number");
    }

}
//Console.WriteLine(car.speed);



Console.ReadLine();
