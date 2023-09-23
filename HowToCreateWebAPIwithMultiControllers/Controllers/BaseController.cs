using HowToCreateWebAPIwithMultiControllers.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HowToCreateWebAPIwithMultiControllers.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class BaseController<T> : ControllerBase
    {
        private readonly IBaseRepository<T> _repository;
        public BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var user = _repository.GetOne(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] T viewModel)
        {
            _repository.Add(viewModel);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] T viewModel)
        {
            _repository.Update(viewModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
