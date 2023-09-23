using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Model;

namespace HowToCreateWebAPIwithMultiControllers.Repository
{
    public class HeroRepository : BaseRepository<HeroViewModel>, IHeroRepository
    {
        public HeroRepository() : base()
        {
        }

        public IEnumerable<HeroViewModel> GetByAge(int age)
        {
            return _table.Where(t => t.Age == age);
        }
    }
}
