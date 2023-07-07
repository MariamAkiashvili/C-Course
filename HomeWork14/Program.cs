using HomeWork14;
using Newtonsoft.Json;

Console.WriteLine("Hello");


Quiz quiz;

int createOrStartQuiz = AskTouser("If You want to create Quiz type 1, if you want to fill Quiz 0 ");
if ( createOrStartQuiz == 1)
{
    string name = "";
    while (!Checks.CheckIsNotEmpty(name))
    {
        Console.WriteLine("Enter new Quiz name: ");
        name = Console.ReadLine();
    }
    
    quiz = new Quiz(name);
    AddQuizQuestions(quiz);



}
else
{
    StartQuiz();

    
}


Console.ReadLine();

int AskTouser(string question)
{
    int ans;
    while (true)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        if(!int.TryParse(input, out ans))
        {
            Console.WriteLine("Please enter only digits");
        }else
        {
            if(ans == 0 || ans == 1)
            {
                break;
            }
            Console.WriteLine("Please choose from provided options");
        }
    }
    return ans;
}


void AddQuizQuestions(Quiz quiz)
{
    int ans = AskTouser("Would you like to add Question to or Save Quiz - " + quiz._name + ", 1 for Add new question, 0 for Save quiz");
    while(ans==1)
    {
        var question = "";
        while(true)
        {
            Console.WriteLine("Please enter the question : ");
            question = Console.ReadLine();
            if(question != "")
            {
                break;
            }
        }
        double point = -1;
        while (point == -1)
        {
            Console.WriteLine("Enter the point of the question");
            var input = Console.ReadLine();
            if(!double.TryParse(input, out point))
            {
                Console.WriteLine("Please enter only digits");
                
            }
            else
            {
                if (point != -1)
                {
                    break;
                }
            }
        }
        var ansLst = AddProbableAnswers();
        var correctAns = CorrectAnswerInList(ansLst);
        var question1 = new Question(question, point, ansLst, correctAns);
        quiz.AddQuestion(question1);
        ans = AskTouser("Would you linke to add Question to Quiz - " + quiz._name + ", 1 for Yes, 0 for No");


    }

    if(ans == 0)
    {
        SaveQuizToFile(quiz);
    }

    
}

List <string> AddProbableAnswers()
{
    List<string> answers = new List<string>();
    int num;
    while (true)
    {
        Console.WriteLine("How many probable answers would you want to add ");
        var input = Console.ReadLine();
        if(!int.TryParse(input, out num))
        {
            Console.WriteLine("Please enter only digits");
        }
        else
        {
            if(num < 0)
            {
                Console.WriteLine("Number of the answers must be more than 0 ");
            }

            break;
        }

    }

    for(int i = 0; i < num;i++)
    {
        while (true)
        {
            Console.WriteLine("Enter Probable Answer");
            var input = Console.ReadLine();
            if(input != "") 
            {
                answers.Add(input);
                break;
            }
        }
    }

    return answers;
}

string CorrectAnswerInList(List<string> probableAnswers)
{
    string correctAnswer="";
    while(true)
    {
        Console.WriteLine("Choose correct answer: ");
        foreach (string input in probableAnswers)
        {
            Console.Write(input+", ");
        }
        Console.WriteLine();
        

        correctAnswer = Console.ReadLine();
        if(probableAnswers.Where(a => a == correctAnswer).Count() == 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please check entered answer");
        }
    }


    return correctAnswer;
}

void SaveQuizToFile(Quiz quiz)
{
    string content = JsonConvert.SerializeObject(quiz);
    File.WriteAllText("quiz.txt",content);
}

void StartQuiz()
{
    Greeting();

    try
    {

        Console.WriteLine("Let's start quiz");
        Quiz quiz = Quiz.ReadQuiz(@"C:\Users\MarAkiashvili\source\repos\C-Course\HomeWork14\bin\Debug\net6.0\quiz.txt");
        Console.WriteLine(quiz._name);

        double mark = AskQuestions(quiz._questions);

        Console.WriteLine("You Have Scored " + mark + " points.");
    }
    catch
    {
        Console.WriteLine("Quiz file cannot be found or file is empty");
    }
    
}

double AskQuestions(List<Question> questions)
{
    double mark=0;
    for(int i = 0 ; i < questions.Count; i++)
    {
        Console.WriteLine("Question "+(i + 1) +" - "+ questions[i]._question + "(" + questions[i]._point+" points)");
        var userAns = CorrectAnswerInList(questions[i]._answers);
        if(userAns.ToLower() == questions[i]._correctAnswer.ToLower()) 
        {
            mark+= questions[i]._point;
        }
    }
    SaveResultsInFile(null, mark);

    return mark;
}

void Greeting()
{
    string fullname = "";
    while (fullname =="")
    {
        Console.WriteLine("Enter your fullname: ");
        fullname = Console.ReadLine();
    }

    SaveResultsInFile(fullname);
}


void SaveResultsInFile(string fullName = default, double score = -1)
{
    string filePath = @"C:\Users\MarAkiashvili\source\repos\C-Course\HomeWork14\bin\Debug\net6.0\QuizResult.txt";
    using (Stream stream = new FileStream(filePath, FileMode.Append))
    {
        using (StreamWriter writer = new StreamWriter(stream))
        {
            if(fullName != null)
            {
                SaveFullName(writer, fullName);
                writer.Write(" - ");
            }
            if(score >= 0)
            {
                SaveScore(writer, score);
                writer.WriteLine("Points");
            }
            writer.Close();
        }
    }
}
void SaveFullName(StreamWriter writer, string fullName)
{
    writer.Write(fullName);
}

void SaveScore(StreamWriter writer, double score)
{
    writer.Write(score);
}