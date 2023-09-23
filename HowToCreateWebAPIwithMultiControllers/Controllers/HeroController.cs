using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPIwithMultiControllers.Controllers
{
    public class HeroController : BaseController<HeroViewModel>
    {
        private readonly IHeroRepository _Repository;
        public HeroController(IHeroRepository repository) : base(repository)
        {
            _Repository = repository;
        }

        [HttpGet("ByAge/{age}")]
        public IActionResult GetByName(int age)
        {
            return Ok(_Repository.GetByAge(age));
        }
    }
}
