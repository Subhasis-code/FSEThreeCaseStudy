using AutoMapper;
using MediatR;
using Member.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Queries.GetMembersList
{
    public class GetMemberListQueryHandler : IRequestHandler<GetMemberListQuery, List<TeamMemberVm>>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetMemberListQueryHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository ?? throw new ArgumentNullException(nameof(memberRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<TeamMemberVm>> Handle(GetMemberListQuery request, CancellationToken cancellationToken)
        {
            var response = await _memberRepository.GetAllAsync();
            return _mapper.Map<List<TeamMemberVm>>(response);
        }
    }
}
