using DesignPattern.Models;
using DesignPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<User> Users { get; }

        public IRepository<Role> Roles { get; }

        public void Save();

    }
}
