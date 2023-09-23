using HowToCreateWebAPIwithMultiControllers.Model;

namespace HowToCreateWebAPIwithMultiControllers.Contract
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetOne(int id);
        void Add(T viewModel);
        void Update(T viewModel);
        void Delete(int id);
    }
}
