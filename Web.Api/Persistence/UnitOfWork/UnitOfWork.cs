using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Data;

namespace Web.Api.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private IGroupRepository _group;

        public IGroupRepository group
        {
            get
            {
                if (this._group == null)
                {
                    this._group = new GroupRepository(dbContext);
                }
                return this._group;
            }
        }

        public int Complete()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
