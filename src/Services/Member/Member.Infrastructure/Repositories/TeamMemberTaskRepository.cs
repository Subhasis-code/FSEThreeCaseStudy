using Member.Application.Contracts.Persistance;
using Member.Domain.Entities;
using Member.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Infrastructure.Repositories
{
    public class TeamMemberTaskRepository : RepositoryBase<MemberTask>, IMemberTaskRepository
    {

        public TeamMemberTaskRepository(MemberContext dbContext) : base(dbContext)
        {

        }
        public async Task<List<MemberTask>> GetTaskListByMemberID(int MemberId)
        {
            //var member = _dbContext.teamMembers.Where(m => m.Id == MemberId).SelectMany(x => x.MemberTaskList).ToList();
            //return member;
            return new List<MemberTask>();
        }
    }
}
