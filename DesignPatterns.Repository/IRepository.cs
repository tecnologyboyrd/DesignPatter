using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public interface IRepository<TEntity>
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(int Id);
        public void Add(TEntity Data);
        public void Update(TEntity Data);
        public void Delete(int Id);
        public void Save();
    }
}
