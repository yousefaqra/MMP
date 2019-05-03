using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Persistence.UnitOfWork
{
    interface IUnitOfWork
    {
        IGroupRepository group { get; }

        Task<int> CompleteAsync();
        int Complete();
    }
}
