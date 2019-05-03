using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModel.Model;
using Web.Api.Data;

namespace Web.Api.Persistence
{
    public class GroupRepository : IGroupRepository
    {

        private readonly AppDbContext context;

        public GroupRepository(AppDbContext dbContext)
        {
            context = dbContext;
        }
        public void addGroup(Group group)
        {
            context.Groups.Add(group);
        }

        public bool deleteGroup(int id)
        {
            var removed = false;
            Group group = getGroup(id);
            if (group != null)
            {
                removed = true;
                context.Groups.Remove(group);
            }

            return removed;
        }

        public Group getGroup(int groupId)
        {
            return context.Groups.Where(x => x.ID == groupId).FirstOrDefault();
        }

        public IEnumerable<Group> getGroups()
        {
            return context.Groups.ToList();
        }
    }
}
