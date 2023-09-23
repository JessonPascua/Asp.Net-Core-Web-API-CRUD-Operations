#nullable disable
using HowToCreateWebAPIwithMultiControllers.Contract;
using HowToCreateWebAPIwithMultiControllers.Contracts;
using HowToCreateWebAPIwithMultiControllers.Infrastructure;

namespace HowToCreateWebAPIwithMultiControllers.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : IBaseViewModel
    {
        protected readonly FakeDbContext _fakeDbContext = new();
        protected readonly List<T> _table;

        public BaseRepository()
        {
            _table = _fakeDbContext.GetTable<T>();
        }

        public void Add(T viewModel)
        {
            viewModel.Id = _table.Count + 1;
            _table.Add(viewModel);
        }

        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public T GetOne(int id)
        {
            return _table.FirstOrDefault(u => u.Id == id);
        }

        public void Update(T viewModel)
        {
            var index = _table.FindIndex(u => u.Id == viewModel.Id);
            _table[index] = viewModel;
        }
        public void Delete(int id)
        {
            _table.RemoveAll(u => u.Id == id);
        }
    }
}
