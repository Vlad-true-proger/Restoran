using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question.Data;

namespace Question.Repositories
{
    public class AnswerRepository
    {
        private QuestionDataBaseEntities _context;

        public AnswerRepository(QuestionDataBaseEntities context)
        {            
            _context = context;
        }
        public IQueryable<Answers1> GetAnswers(int questionId)
        {
            return _context.Answers1.Where(x => x.QuestionID == questionId);
        }

        public IQueryable<Answers1> GetAnswersByQuestionTitle(string questionTitle)
        {
            return _context.Answers1.Where(x => x.Questions.QuestionText == questionTitle);
        }

        public void AddAnswer(string questionTitle, string answer, int UserID)
        {
            Answers1 answer1 = new Answers1();
            answer1.QuestionID = _context.Questions.FirstOrDefault(x => x.QuestionText == questionTitle).QuestionID;
            answer1.Answer = answer;
            answer1.UserID = UserID;
            _context.Answers1.Add(answer1);        
            _context.SaveChanges();
        }
    }
}
