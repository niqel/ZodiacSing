using ZodiacSign.Domain.Entities;
using ZodiacSign.Domain.IRepositories;
using ZodiacSign.Persistence.Configurations.DbContext;
using ZodiacSign.Persistence.Repositories;

namespace ZodiacSign.Persistence
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ZodiacSignDbContext zodiacSignDbContext;
        private readonly IRepository<Element> elements;
        private readonly IRepository<Gem> gems;
        private readonly IRepository<Home> homes;
        private readonly IRepository<Sign> signs;
       
        public IRepository<Element> Elements { get { return this.elements; } }
        public IRepository<Gem> Gems { get { return this.gems; } }

        public IRepository<Home> Homes { get { return this.homes; } }

        public IRepository<Sign> Signs { get { return this.signs; } }

        public UnityOfWork(ZodiacSignDbContext zodiacSignDbContext)
        {
            this.zodiacSignDbContext = zodiacSignDbContext;
            this.elements = new Repository<Element>(this.zodiacSignDbContext);
            this.gems = new Repository<Gem>(this.zodiacSignDbContext);
            this.homes = new Repository<Home>(this.zodiacSignDbContext);
            this.signs = new Repository<Sign>(this.zodiacSignDbContext);
        }

        public void SaveChange()
        {
            this.zodiacSignDbContext.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
            await this.zodiacSignDbContext.SaveChangesAsync();
        }
    }
}
