using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPIwithMultiControllers.Controllers
{
    public class UserController : BaseController<UserViewModel>
    {
        public UserController(IBaseRepository<UserViewModel> repository) : base(repository)
        {
        }
    }
}
