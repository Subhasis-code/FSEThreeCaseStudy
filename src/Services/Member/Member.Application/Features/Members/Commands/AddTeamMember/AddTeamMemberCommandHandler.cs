using AutoMapper;
using MediatR;
using Member.Application.Contracts.Persistance;
using Member.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Commands.AddTeamMember
{
    public class AddTeamMemberCommandHandler : IRequestHandler<AddTeamMemberCommand, int>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddTeamMemberCommandHandler> _logger;

        public AddTeamMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper, ILogger<AddTeamMemberCommandHandler> logger)
        {
            _memberRepository = memberRepository ?? throw new ArgumentNullException(nameof(memberRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<int> Handle(AddTeamMemberCommand request, CancellationToken cancellationToken)
        {
            var teamMemberEntity = _mapper.Map<TeamMember>(request);
            var newTeamMember = await _memberRepository.AddAsync(teamMemberEntity);
            _logger.LogInformation($"new team member {newTeamMember.Id} added");
            return newTeamMember.Id;
        }
    }
}
