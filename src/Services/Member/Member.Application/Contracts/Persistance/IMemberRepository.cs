using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member.Domain.Entities;

namespace Member.Application.Contracts.Persistance
{
    public interface IMemberRepository : IAsyncRepository<TeamMember>
    {
        Task<TeamMember> GetTeamMembersByID(int MemberId);
    }
}
