using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Queries.GetMemberTaskList
{
    public class GetMemberTaskListQuery : IRequest<List<MemberTaskVm>>
    {
        public int MemberId { get; set; }

        public GetMemberTaskListQuery(int memberId)
        {
            MemberId = memberId;
        }
    }
}
