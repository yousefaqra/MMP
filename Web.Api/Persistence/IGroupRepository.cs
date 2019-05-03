using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Persistence
{
    interface IGroupRepository
    {
        void addGroup(Group group);
        Group getGroup(int id);
        IEnumerable<Group> getGroups();
    }
}
