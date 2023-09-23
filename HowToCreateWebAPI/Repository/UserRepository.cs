using HowToCreateWebAPI.Contract;
using HowToCreateWebAPI.Infrastructure;
using HowToCreateWebAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace HowToCreateWebAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly FakeDbContext _fakeDbContext = new FakeDbContext();

        public void Add(UserViewModel user)
        {
            user.Id = _fakeDbContext.Users.Count + 1;
            _fakeDbContext.Users.Add(user);
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            return _fakeDbContext.Users;
        }

        public UserViewModel GetOne(int id)
        {
            return _fakeDbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(UserViewModel user)
        {
            var index = _fakeDbContext.Users.FindIndex(u => u.Id == user.Id);
            _fakeDbContext.Users[index] = user;
        }

        public void Delete(int id)
        {
            _fakeDbContext.Users.RemoveAll(u => u.Id == id);
        }

    }
}
