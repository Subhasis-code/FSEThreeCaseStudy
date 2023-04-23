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
    public class TeamMemberRepository : RepositoryBase<TeamMember>, IMemberRepository
    {
        public TeamMemberRepository(MemberContext dbContext) : base(dbContext)
        {

        }

        public async Task<TeamMember> GetTeamMembersByID(int MemberId)
        {
            var member = _dbContext.teamMembers.Where(m => m.Id == MemberId).FirstOrDefault();
            return member;
        }
    }
}
