using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Domain.Entities;
using Manager.Infra.Repository;

namespace Manager.Infra.Interface
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email);

        Task<List<User>> SearchByEmail(string email);

        Task<List<User>> SearchByName(string name);
    }
}
