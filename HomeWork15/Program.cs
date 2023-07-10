using HomeWork15;
using System.Reflection;

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

object chosenClassInstance = Activator.CreateInstance(classType);

//show class info

Console.WriteLine($"Class Type Name: {classType.Name}");
//GetProperties();
//GetMethods();


var methodOrProperty = ChooseMethodOrProperties();
if(methodOrProperty == "method")
{
    ChooseMethod();
}else
{
    ChooseProperties();
}


string ChooseMethodOrProperties()
{
    string ans = "";
    while (ans=="")
    {
        Console.WriteLine("If you wnat to choose method type : method, else type : property ");
        ans =Console.ReadLine();
        if(ans.ToLower() == "method" || ans.ToLower() == "property")
        {
            break;
        }
        else 
        {
            Console.WriteLine("Check typed values");
            ans = "";
        }
    }
    return ans.ToLower();
}


void GetProperties()
{
    foreach (PropertyInfo property in classType.GetProperties())
    {
        Console.WriteLine($"Property Name:  {property.Name}");

    }
}


void ChooseProperties()
{
    bool stopLoop = false;
    string propertyField = "";
    while (!stopLoop)
    {
        Console.WriteLine("Choose property: ");
        GetProperties();
        propertyField = Console.ReadLine();

        foreach (PropertyInfo property in classType.GetProperties())
        {
            if (property.Name == propertyField)
            {
                stopLoop = true;
            }

        }
        if (!stopLoop)
        {
            Console.WriteLine("Please check property field name");
            
        }

    }
    PropertyInfo propertyInfo = classType.GetProperty(propertyField);
    Console.WriteLine($"property '{propertyInfo.Name}' value {(string) propertyInfo.GetValue(chosenClassInstance)}");
}




void GetMethods()
{
    foreach (MethodInfo method in classType.GetMethods())
    {
        Console.WriteLine($"Method Name:  {method.Name}");
        
    }
}

List<object> ShowMethodsParameters(string methodName)
{
    List <object> inputParameters = new List<object>();
    MethodInfo method = classType.GetMethod(methodName);
    ParameterInfo[] parameters = method.GetParameters();

    if(parameters.Length > 0)
    {
        Console.WriteLine("Method has following parameters : ");
    }
    foreach(ParameterInfo param in parameters)
    {        
        while (true)
        {
            Console.WriteLine($"Mehtod parameter {param.Name} (Type : {param.ParameterType})");
            object input = Console.ReadLine();
           
            if(input != null)
            {
                inputParameters.Add(param);
                break;
            }
        }        
    }
    return inputParameters;
}

void ChooseMethod()
{
    bool stopLoop = false;
    string methodName = "";
    while (!stopLoop)
    {
        Console.WriteLine("Choose Method You Want To Execute: ");
        GetMethods();
        methodName = Console.ReadLine();

        foreach (MethodInfo method in classType.GetMethods())
        {
            if(method.Name == methodName)
            {
                stopLoop = true;
            }

        }
        if( !stopLoop)
        {
            Console.WriteLine("Please check method name");
            
        }
        
    }

    ExecuteMethod(methodName);

}


void ExecuteMethod(string methodName)
{
    Console.WriteLine("You have to pass following parameters to call method;");
    List<object> userParams = ShowMethodsParameters(methodName);
    try
    {

        MethodInfo  method = classType.GetMethod(methodName);
        ParameterInfo[] parameters = method.GetParameters();

        if (method!= null)

        {
            object[] parameterArray = new object[userParams.Count];
            for (int i = 0; i < userParams.Count; i++)
            {

                if (parameters[i].ParameterType == typeof(int))
                {
                    if (int.TryParse(userParams[i].ToString(), out int intValue))
                    {
                        parameterArray[i] = intValue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid value for parameter {parameters[i].Name}");
                        return;
                    }
                }else if (parameters[i].ParameterType == typeof(double))
                {
                    if (double.TryParse(userParams[i].ToString(), out double doubleValue))
                    {
                        parameterArray[i] = doubleValue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid value for parameter {parameters[i].Name}");
                        return;
                    }
                }else if (parameters[i].ParameterType == typeof(string))
                {
                    try 
                    {
                        parameterArray[i] = parameters[i].ToString();
                    }
                    catch
                    {
                        Console.WriteLine($"Invalid value for parameter {parameters[i].Name}");
                        return;
                    }
                }else if (parameters[i].ParameterType == typeof(List<object>))
                {
                    parameterArray = parameters;
                }
                else
                {
                    throw new Exception("Unexpected Value");
                }



                //parameterArray[i] = Convert.ChangeType(userParams[i], parameters[i].ParameterType);
            }
            method.Invoke(chosenClassInstance, parameterArray);
        }
        Console.WriteLine("Method executed successfuly");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.ToString());
    }
}





Console.ReadLine();