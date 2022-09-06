using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;

namespace DesignPatternsASP.Strategy
{
    public interface IUserStrategy
    {
        public void add(UserRoleViewModel UserrolVm, IUnitOfWork unitOfWork);
    }
}
