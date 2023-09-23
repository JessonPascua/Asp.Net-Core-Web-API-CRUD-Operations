using HowToCreateWebAPIwithMultiControllers.Contracts;
using System.ComponentModel.DataAnnotations;

namespace HowToCreateWebAPIwithMultiControllers.Model
{
    public class HeroViewModel : IBaseViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
