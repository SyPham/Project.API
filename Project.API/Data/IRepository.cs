using System.Collections.Generic;
using System.Threading.Tasks;
using Project.API.Helpers;
using Project.API.Models;

namespace Project.API.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int id, bool isCurrentUser);
    }
}