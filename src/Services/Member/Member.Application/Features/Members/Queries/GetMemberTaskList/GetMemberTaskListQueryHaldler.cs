using AutoMapper;
using MediatR;
using Member.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Queries.GetMemberTaskList
{
    public class GetMemberTaskListQueryHaldler : IRequestHandler<GetMemberTaskListQuery, List<MemberTaskVm>>
    {
        private readonly IMemberTaskRepository _memberTaskRepository;
        private readonly IMapper _mapper;

        public GetMemberTaskListQueryHaldler(IMemberTaskRepository memberTaskRepository, IMapper mapper)
        {
            _memberTaskRepository = memberTaskRepository ?? throw new ArgumentNullException(nameof(memberTaskRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<MemberTaskVm>> Handle(GetMemberTaskListQuery request, CancellationToken cancellationToken)
        {
            var response = await _memberTaskRepository.GetTaskListByMemberID(request.MemberId);
            return _mapper.Map<List<MemberTaskVm>>(response);
        }
    }
}
