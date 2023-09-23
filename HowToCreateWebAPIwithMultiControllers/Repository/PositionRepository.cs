using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Model;

namespace HowToCreateWebAPIwithMultiControllers.Repository
{
    public class PositionRepository : BaseRepository<PositionViewModel>, IPositionRepository
    {
        public PositionRepository() : base()
        {
        }
    }
}
