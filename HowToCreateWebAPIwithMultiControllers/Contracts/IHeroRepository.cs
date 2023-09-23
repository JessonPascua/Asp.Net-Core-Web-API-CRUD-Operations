using HowToCreateWebAPIwithMultiControllers.Model;

namespace HowToCreateWebAPIwithMultiControllers.Contract
{
    public interface IHeroRepository: IBaseRepository<HeroViewModel>
    {
        IEnumerable<HeroViewModel> GetByAge(int age);
    }
}
