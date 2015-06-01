using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question.Data;

namespace Question.Repositories
{
    public class UserReporitory
    {
        private QuestionDataBaseEntities _context;

        public UserReporitory(QuestionDataBaseEntities context)
        {
            _context = context;
        }

        public IQueryable<Users> GetUsers()
        {
            return _context.Users;
        }

        public Users GetUser(string login, string password)
        {
            return ValidateUser(login, password);
        }

        private Users ValidateUser(string login, string password)
        {
            return _context.Users
                .FirstOrDefault(x => x.Login == login && x.Password == password);
        }
    }
}
