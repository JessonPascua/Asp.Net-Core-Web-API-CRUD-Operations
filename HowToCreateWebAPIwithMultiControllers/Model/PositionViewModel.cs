using HowToCreateWebAPIwithMultiControllers.Contracts;
using System.ComponentModel.DataAnnotations;

namespace HowToCreateWebAPIwithMultiControllers.Model
{
    public class PositionViewModel : IBaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
