using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.Domain.IRepositories;
using ZodiacSign.Persistence.Configurations.DbContext;

namespace ZodiacSign.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ZodiacSignDbContext zodiacSignDbContext;
        protected DbSet<TEntity> dbSet;

        public Repository(ZodiacSignDbContext zodiacSignDbContext)
        {
            this.zodiacSignDbContext = zodiacSignDbContext;
            this.dbSet = this.zodiacSignDbContext.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        public void CreateAll(IEnumerable<TEntity> entities)
        {
            this.dbSet.AddRange(entities);
        }

        public async Task CreateAllAsync(IEnumerable<TEntity> entities)
        {
            await this.dbSet.AddRangeAsync(entities);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await this.dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public void DeleteAll(IEnumerable<TEntity> entities)
        {
            this.dbSet.RemoveRange(entities);
        }

        public Task DeleteAllAsync(IEnumerable<TEntity> entities)
        {
            this.dbSet.RemoveRange(entities);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(TEntity entity)
        {
            this.dbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public IQueryable<TEntity> Read()
        {
            return this.dbSet;
        }

        public TEntity? ReadById(int id)
        {
            TEntity? entity = this.dbSet.Find(id);
            return entity;
        }

        public void Update(TEntity entity)
        {
            this.dbSet.Update(entity);
        }

        public void UpdateAll(IEnumerable<TEntity> entities)
        {
            this.dbSet.UpdateRange(entities);
        }

        public Task UpdateAllAsync(IEnumerable<TEntity> entities)
        {
            this.dbSet.UpdateRange(entities);
            return Task.CompletedTask;
        }

        public Task UpdateAync(TEntity entity)
        {
            this.dbSet.Update(entity);
            return Task.CompletedTask;
        }
    }
}
