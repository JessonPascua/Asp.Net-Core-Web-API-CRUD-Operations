using HowToCreateWebAPIwithMultiControllers.Contracts;

namespace HowToCreateWebAPIwithMultiControllers.Model
{
    public class UserViewModel : IBaseViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
