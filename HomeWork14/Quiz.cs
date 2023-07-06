using Newtonsoft.Json;

namespace HomeWork14
{
    [Serializable]
    public class Quiz
    {
        public string _name;
        public List <Question> _questions;

        public Quiz(string name) 
        {
            if (Checks.CheckIsNotEmpty(name))
            {
                this._name = name;
                _questions = new List<Question>();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }
        public void SetQuestions(List <Question> questions)
        {
            this._questions = questions;
        }
        public List <Question> GetQuestions()
        {
            return this._questions;
        }
        ///#######################################################
        public static Quiz ReadQuiz(string fileName)
        {
            
            string jsonData = File.ReadAllText(fileName);
            var quizData = JsonConvert.DeserializeObject<QuizData>(jsonData);
            
            Quiz quiz = new Quiz(quizData._name);
            quiz.SetQuestions(quizData._questions);
           
            return quiz;

        }
    }
}
