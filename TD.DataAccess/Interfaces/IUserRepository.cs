using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.Model.Entities;

namespace TD.DataAccess.Interfaces
{
    public interface IUserRepository:IBaseRepository<User>
    {
    }
}
