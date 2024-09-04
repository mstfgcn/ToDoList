using Infrastructure.DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.DataAccess.Implementations.EF.Contexts;
using TD.DataAccess.Interfaces;
using TD.Model.Entities;

namespace TD.DataAccess.Implementations.EF.Repositories
{
    public class OderRepository : BaseRepository<Order, ToDoListContext>, IOrderRepository
    {
       
    }
}
