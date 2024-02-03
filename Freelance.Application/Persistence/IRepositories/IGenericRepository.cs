﻿namespace Freelance.Application.Persistence.IRepositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> PostAsync(T entity);
    Task<T> PutAsync(int id, T entity);
    Task DeleteAsync(int id);
}
