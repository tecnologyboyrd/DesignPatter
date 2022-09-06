using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViwModels;

namespace DesignPatternsASP.Strategy
{
    public class UserContext
    {
        private IUserStrategy _strategy;

        public IUserStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public UserContext(IUserStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(UserRoleViewModel UserrolVm, IUnitOfWork unitOfWork)
        {
            _strategy.add(UserrolVm, unitOfWork);            
        }
    }
}
