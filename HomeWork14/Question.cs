using Newtonsoft.Json;


namespace HomeWork14
{
    public class Question
    {
        [JsonProperty("_question")]
        public string _question;
        [JsonProperty("_point")]
        public double _point;
        [JsonProperty("_answers")]
        public List<string> _answers;
        [JsonProperty("_correctAnswer")]
        public string _correctAnswer;

        
        public Question()
        { 
            //for only Json Deserialization
        }
        public Question(string question, double point, List<string> answers, string correctAnswer)
        {
            if (Checks.CheckIsNotEmpty(question))
            {
                _question = question;
            }
            else
            {
                throw new ArgumentNullException();
            }
            if (point >= 0)
            {
                _point = point;
            }
            else
            {
                throw new ArgumentNullException();
            }
            if (Checks.CheckIsNotEmpty(answers))
            {
                _answers = answers;
            }
            else
            {
                throw new ArgumentNullException();
            }
            if (Checks.CheckIsNotEmpty(correctAnswer))
            {
                _correctAnswer = correctAnswer;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public string GetQuestion() { return _question; }
        public double GetPoint() { return _point; }
        public List<string> GetAnswers() { return _answers; }

        public void AddAnswers(List<string> answers)
        {
            if (Checks.CheckIsNotEmpty(answers))
            {
                _answers = answers;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

    }
}
