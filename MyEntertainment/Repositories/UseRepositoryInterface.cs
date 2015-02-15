using MyEntertainment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntertainment.Repositories
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<UserModel> GetAll();
        UserModel GetUserByID(String userId);
        void InsertUser(UserModel user);
        void DeleteUser(String userId);
        void UpdateUser(UserModel user);
        void Save();
    }
}
