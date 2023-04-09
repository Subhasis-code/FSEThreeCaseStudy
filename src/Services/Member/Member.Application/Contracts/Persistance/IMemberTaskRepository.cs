using Member.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Contracts.Persistance
{
    public interface IMemberTaskRepository : IAsyncRepository<MemberTask>
    {
        Task<List<MemberTask>> GetTaskListByMemberID(int MemberId);
    }
}
