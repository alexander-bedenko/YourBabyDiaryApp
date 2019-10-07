﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.BLL.Interfaces
{
    public interface ICrudService<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseDto
    {
        Task DeleteAsync(int id);
        Task Create(TModel model);
        Task<TModel> UpdateAsync(TModel model);
        Task<IEnumerable<TModel>> GetAllAsync(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TModel>> GetAllAsync();
        IEnumerable<TModel> GetAll(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TModel> GetAll();
        Task<TModel> GetAsync(Expression<Func<TEntity, bool>> filter);
        TModel Get(Expression<Func<TEntity, bool>> filter);
    }
}