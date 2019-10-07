using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.BLL.Interfaces;
using YourBabyDiary.DAL.Entities;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Services
{
    public class CrudService<TEntity, TModel> : BaseService, ICrudService<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseDto, new()
    {
        protected CrudService(IUnitOfWork uow, IMapper mapper)
            : base(uow, mapper)
        {
        }

        public async Task<IEnumerable<TModel>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            var entities = await _uow.Repository<TEntity>().GetAllAsync(filter);
            var dtos = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TModel>>(entities);

            return dtos;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var entities = await _uow.Repository<TEntity>().GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TModel>>(entities);

            return dtos;
        }


        public IEnumerable<TModel> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            var entities = _uow.Repository<TEntity>().GetAll(filter);
            var dtos = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TModel>>(entities);

            return dtos;
        }

        public IEnumerable<TModel> GetAll()
        {
            var entities = _uow.Repository<TEntity>().GetAll();
            var dtos = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TModel>>(entities);

            return dtos;
        }

        public async Task<TModel> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            var entity = await _uow.Repository<TEntity>().GetAsync(filter);
            var dto = _mapper.Map<TModel>(entity);

            return dto;
        }

        public TModel Get(Expression<Func<TEntity, bool>> filter)
        {
            var entity = _uow.Repository<TEntity>().Get(filter);
            var dto = _mapper.Map<TModel>(entity);

            return dto;
        }

        public async Task Create(TModel model)
        {
            await _uow.Repository<TEntity>().Create(_mapper.Map<TEntity>(model));
            await _uow.Commit();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _uow.Repository<TEntity>().GetAsync(x => x.Id == id);
            await _uow.Repository<TEntity>().DeleteAsync(_mapper.Map<TEntity>(entity));
            await _uow.Commit();
        }

        public async Task<TModel> UpdateAsync(TModel model)
        {
            var entity = await _uow.Repository<TEntity>().UpdateAsync(_mapper.Map<TEntity>(model));
            await _uow.Commit();

            return _mapper.Map<TModel>(entity);
        }
    }
}
