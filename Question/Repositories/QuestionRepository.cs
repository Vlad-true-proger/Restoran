using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question.Data;

namespace Question.Repositories
{
    public class QuestionRepository
    {
        private QuestionDataBaseEntities _context;

        public QuestionRepository(QuestionDataBaseEntities context)
        {
            _context = context;
        }
        public void SaveQuestion(string title, string answer1, string answer2, string answer3)
        {
            _context.Questions.Add(new Questions { Answer1 = answer1, Answer2 = answer2, Answer3 = answer3, QuestionText = title });
                _context.SaveChanges();
        }
        public IQueryable<Questions> GetQuestions()
        {
            return _context.Questions;
        }

        public IEnumerable<string> GetAnswersByQuestionTitle(string questionTitle)
        {
            var questions = _context.Questions.FirstOrDefault(x=> x.QuestionText == questionTitle);
            return new List<string>{ questions.Answer1, questions.Answer2, questions.Answer3 };
        }
    }
}
