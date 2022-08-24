using DesignPatters.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Repository.UnitOfWork;

namespace DesignPatterns.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DesignPatternsContext _context;        

        private IRepository<Users> _users;

        private IRepository<Roles> _roles;


        public UnitOfWork(DesignPatternsContext Context)
        {
            _context = Context; 
            
        }

        public IRepository<Users> Users
        {
            get
            {
                return _users == null ? _users = new Repository<Users>(_context) : _users;
            }
        }

        public IRepository<Roles> Roles
        {
            get
            {
                return _roles == null ? _roles = new Repository<Roles>(_context) : _roles;
            }
        }        

        public void Save()
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception Exp)
            {
                transaction.Rollback();
                
            }
        }
    }
}
