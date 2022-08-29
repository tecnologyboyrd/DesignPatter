using DesignPatters.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Users> Users { get; }

        public IRepository<Roles> Roles { get; }

        public IRepository<UserRoleAssignment> UserroleAssignment { get; }

        public void Save();

    }
}
