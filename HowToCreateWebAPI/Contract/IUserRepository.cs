using HowToCreateWebAPI.Model;
using System.Collections;
using System.Collections.Generic;

namespace HowToCreateWebAPI.Contract
{
    public interface IUserRepository
    {
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetOne(int id);
        void Add(UserViewModel user);
        void Update(UserViewModel user);
        void Delete(int id);
    }
}
