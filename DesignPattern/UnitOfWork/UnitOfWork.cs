using DesignPattern.Models;
using DesignPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {
        private DesignPatternsContext _context;        

        private IRepository<User> _users;

        private IRepository<Role> _roles;


        public UnitOfWork(DesignPatternsContext Context)
        {
            _context = Context; 
            
        }

        public IRepository<User> Users
        {
            get
            {
                return _users == null ? _users = new Repository<User>(_context) : _users;
            }
        }

        public IRepository<Role> Roles
        {
            get
            {
                return _roles == null ? _roles = new Repository<Role>(_context) : _roles;
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
