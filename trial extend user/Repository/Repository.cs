
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using trial_extend_user.Data;
using trial_extend_user.Repository.IRepository;

namespace trial_extend_user.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationDbContext _db;
		internal DbSet<T> dbSet;
		public Repository(ApplicationDbContext db, DbSet<T> ts)
		{
			_db = db;
			this.dbSet = db.Set<T>();
		}

		public void Add(T entity)
		{
			dbSet.Add(entity);
		}

		public int Count()
		{
			throw new NotImplementedException();
		}

		public int Count(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<int> CountAsync()
		{
			throw new NotImplementedException();
		}

		public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public void Delete(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public T FirstOrDefault(int id)
		{
			throw new NotImplementedException();
		}

		public T FirstOrDefault(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<T> FirstOrDefaultAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public T Get(int id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> GetAll()
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] propertySelectors)
		{
			throw new NotImplementedException();
		}

		public List<T> GetAllList()
		{
			throw new NotImplementedException();
		}

		public List<T> GetAllList(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<List<T>> GetAllListAsync()
		{
			throw new NotImplementedException();
		}

		public Task<List<T>> GetAllListAsync(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetAsync(int id)
		{
			throw new NotImplementedException();
		}

		public T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
		{
			IQueryable<T> query = dbSet;
			if (filter != null)
			{
				query = query.Where(filter);
			}
			if (includeProperties != null)
			{
				//abc,,xyz -> abc xyz
				foreach (var includeProperty in includeProperties.Split(
					new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProperty);
				}
			}
			return query.FirstOrDefault();
		}

		public T Insert(T entity)
		{
			throw new NotImplementedException();
		}

		public int InsertAndGetId(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<int> InsertAndGetIdAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> InsertAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public T InsertOrUpdate(T entity)
		{
			throw new NotImplementedException();
		}

		public int InsertOrUpdateAndGetId(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<int> InsertOrUpdateAndGetIdAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> InsertOrUpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public T Load(int id)
		{
			throw new NotImplementedException();
		}

		public long LongCount()
		{
			throw new NotImplementedException();
		}

		public long LongCount(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<long> LongCountAsync()
		{
			throw new NotImplementedException();
		}

		public Task<long> LongCountAsync(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public T1 Query<T1>(Func<IQueryable<T>, T1> queryMethod)
		{
			throw new NotImplementedException();
		}

		public void Remove(T entity)
		{
			dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entity)
		{
			dbSet.RemoveRange(entity);
		}

		public T Single(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Task<T> SingleAsync(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public T Update(T entity)
		{
			throw new NotImplementedException();
		}

		public T Update(int id, Action<T> updateAction)
		{
			throw new NotImplementedException();
		}

		public Task<T> UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> UpdateAsync(int id, Func<T, Task> updateAction)
		{
			throw new NotImplementedException();
		}

		IEnumerable<T> IRepository<T>.GetAll()
		{
			IQueryable<T> query = dbSet;
		}
	}
}
