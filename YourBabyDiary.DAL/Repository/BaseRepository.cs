﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YourBabyDiary.DAL.Entities;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.DAL.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        private readonly IYourBabyDiaryContext _context;

        public BaseRepository(IYourBabyDiaryContext context)
        {
            _context = context;
        }

        public async Task Create(T entity) => await _context.Set<T>().AddAsync(entity);

        public async Task DeleteAsync(T entity)
        {
            var storedEntity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == entity.Id);
            _context.Set<T>().Remove(storedEntity);
        }

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter) => _context.Set<T>().Where(filter).ToList();

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter) =>
            await _context.Set<T>().Where(filter).ToListAsync();

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter) =>
            await _context.Set<T>().FirstOrDefaultAsync(filter);

        public T Get(Expression<Func<T, bool>> filter) =>
            _context.Set<T>().FirstOrDefault(filter);

        public async Task<T> UpdateAsync(T entity)
        {
            var storedEntity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == entity.Id);
            _context.Entry(storedEntity).CurrentValues.SetValues(entity);
            return storedEntity;
        }
    }
}
