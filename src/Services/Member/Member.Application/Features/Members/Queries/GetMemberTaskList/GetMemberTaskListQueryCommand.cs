using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Queries.GetMemberTaskList
{
    public class GetMemberTaskListQueryCommand : IRequestHandler<GetMemberTaskListQuery, List<MemberTaskVm>>
    {
        public Task<List<MemberTaskVm>> Handle(GetMemberTaskListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
