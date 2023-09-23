using HowToCreateWebAPIwithMultiControllers.Model;

namespace HowToCreateWebAPIwithMultiControllers.Infrastructure
{
    public class FakeDbContext
    {
        public FakeDbContext()
        {
            Users = new List<UserViewModel>();
            Heroes = new List<HeroViewModel>();
            Positions = new List<PositionViewModel>();
        }
        public List<UserViewModel>? Users { get; set; }
        public List<HeroViewModel>? Heroes { get; set; }
        public List<PositionViewModel>? Positions { get; set; }

        public List<T>? GetTable<T>()
        {
            return GetType()
                .GetProperties()
                .FirstOrDefault(p => p.GetValue(this, null) is List<T>)
                ?.GetValue(this, null) as List<T>;
        }
    }
}
