using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Queries.GetMembersList
{
    public class GetMemberListQuery : IRequest<List<TeamMemberVm>>
    {
        public int MemberID { get; set; }
        public GetMemberListQuery(int memberID)
        {
            MemberID = memberID;
        }

    }
}
