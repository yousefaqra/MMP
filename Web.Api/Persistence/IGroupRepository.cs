using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Persistence
{
   public interface IGroupRepository
    {
        void addGroup(Group group);
        Group getGroup(int groupId);
        IEnumerable<Group> getGroups();
        bool deleteGroup(int id);
    }
}
