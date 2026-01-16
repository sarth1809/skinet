using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T?> GetEntityBySpec(ISpecification<T> spec);
    Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);
    Task<TResult?> GetEntityBySpec(ISpecification<T, TResult> spec);
    Task<IReadOnlyList<TResult>> GetAsync<TResult>(ISpecification<T,TResult> spec);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    Task<bool> SaveAllAsync();
    bool Exists(int id);
}

public class TResult
{
}