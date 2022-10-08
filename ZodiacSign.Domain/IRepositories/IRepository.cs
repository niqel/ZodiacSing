using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.Domain.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity? ReadById(int id);
        public IQueryable<TEntity> Read();
        void Create(TEntity entity);
        void CreateAll(IEnumerable<TEntity> entities);
        Task CreateAsync(TEntity entity);
        Task CreateAllAsync(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateAll(IEnumerable<TEntity> entities);
        Task UpdateAync(TEntity entity);
        Task UpdateAllAsync(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteAll(IEnumerable<TEntity> entities);
        Task DeleteAsync(TEntity entity);
        Task DeleteAllAsync(IEnumerable<TEntity> entities);
    }

    public class Repository
    { 
        private void ReadByID()
    }
}
