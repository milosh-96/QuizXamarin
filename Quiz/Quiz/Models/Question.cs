using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Models
{
    public class Question
    {
        public Question(string category, string type, string difficulty, string question, string correct_answer, List<string> incorrect_answers)
        {
            this.category = category;
            this.type = type;
            this.difficulty = difficulty;
            this.question = question;
            this.correct_answer = correct_answer;
            this.incorrect_answers = incorrect_answers;
        }

        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public List<string> incorrect_answers { get; set; }
    }

    public class Questions
    {
        public int response_code { get; set; }
        public List<Question> results { get; set; }
    }
}
