using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question.Repositories;

namespace Question.Data
{
    public class DataManager
    {
        public UserReporitory Users { get; set; }
        public QuestionRepository Questions { get; set; }
        public AnswerRepository Answers { get; set; }

        public DataManager(QuestionDataBaseEntities context)
        {
            Users = new UserReporitory(context);
            Questions = new QuestionRepository(context);
            Answers = new AnswerRepository(context);
        }
    }
}
