using CNET_V7_Entities.Data;
using CNET_V7_Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CNET_V7_Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected CnetV7DbContext _context;

        public Repository(CnetV7DbContext context) => _context = context;


        public async Task<T> FindById(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception) { throw; }    
        }

        public async Task<T> Create(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> Update(T entity)
        {
            try
            {
                _context.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> Delete(int id) {
            try
            {
                var entity = await _context.Set<T>().FindAsync(id);
                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }  

        public async Task<IEnumerable<T>> FindAll(bool trackChanges)
        {
            try
            {
                if (trackChanges)
                {
                    return await _context.Set<T>().AsNoTracking().ToListAsync();
                }
                else
                {
                    return await _context.Set<T>().ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            try
            {
                if (!trackChanges)
                    return await _context.Set<T>().Where(expression).AsNoTracking().ToListAsync();
                else
                    return await _context.Set<T>().Where(expression).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
