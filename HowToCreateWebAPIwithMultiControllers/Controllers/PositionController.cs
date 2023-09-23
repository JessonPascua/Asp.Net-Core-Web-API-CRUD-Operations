using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPIwithMultiControllers.Controllers
{
    public class PositionController : BaseController<PositionViewModel>
    {
        public PositionController(IBaseRepository<PositionViewModel> repository) : base(repository) 
        {
        }
    }
}
