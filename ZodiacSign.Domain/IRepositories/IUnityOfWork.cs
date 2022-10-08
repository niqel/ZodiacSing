
using ZodiacSign.Domain.Entities;

namespace ZodiacSign.Domain.IRepositories
{
    public interface IUnityOfWork
    {
        IRepository<Element> Elements { get; }
        IRepository<Gem> Gems { get; }
        IRepository<Home> Homes { get; }
        IRepository<Sign> Signs { get; }

        public void SaveChange();
        public Task SaveChangeAsync();
    }
}
