using HomeWork15;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Claims;

Console.WriteLine("Hello, World!");

string ans = "";
bool isValid = false;

while (!isValid)
{
    Console.WriteLine("Choose class: ");
    foreach (ClassTypes item in  Enum.GetValues(typeof(ClassTypes)))
    {
        Console.WriteLine(item.ToString());
    }
    ans = Console.ReadLine();

    foreach (ClassTypes item in Enum.GetValues(typeof(ClassTypes)))
    {
        if(ans.ToLower()  == item.ToString().ToLower()) 
        {
            isValid = true;
            break;
        }
    }
    if(!isValid)
    {
        Console.WriteLine("Please choose from provided options");
    }
    else{
        Console.WriteLine("You have chosen '" + ans + "' class");
    } 
}



//Define class type
Type classType;

if(ans.ToLower() == ClassTypes.COMPANY.ToString().ToLower())
{
    classType = typeof(Company);
}else if(ans.ToLower() == ClassTypes.EMPLOYEE.ToString().ToLower())
{
    classType = typeof(Employee);
}else
{
    classType= typeof(Building);
}


//show class info

Console.WriteLine($"Class Type Name: {classType.Name}");

foreach(PropertyInfo property in classType.GetProperties())
{
    Console.WriteLine($"Property Name:  {property.Name}");
}





Console.ReadLine();