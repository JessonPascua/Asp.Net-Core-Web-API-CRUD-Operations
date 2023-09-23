using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Model;

namespace HowToCreateWebAPIwithMultiControllers.Repository
{
    public class UserRepository : BaseRepository<UserViewModel>, IUserRepository
    {
        public UserRepository() : base()
        {
            
        }
    }
}
