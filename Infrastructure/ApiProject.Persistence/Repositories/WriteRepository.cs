using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using ApiProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _dbContext;

        public WriteRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private DbSet<T> Table { get => _dbContext.Set<T>(); }
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }
        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }

        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task SoftDeleteAsync(T entity)
        {
            
            await Task.Run(() => Table.Update(entity));
          
        }

        
    }
}
