using AutoMapper;
using MediatR;
using Member.Application.Contracts.Persistance;
using Member.Application.Exception;
using Member.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Commands.UpdateTeamMember
{
    public class UpdateTeamMemberCommandHandler : IRequestHandler<UpdateTeamMemberCommand, int>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTeamMemberCommandHandler> _logger;

        public UpdateTeamMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper, ILogger<UpdateTeamMemberCommandHandler> logger)
        {
            _memberRepository = memberRepository ?? throw new ArgumentNullException(nameof(memberRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<int> Handle(UpdateTeamMemberCommand request, CancellationToken cancellationToken)
        {
            var memberToUpdate = await _memberRepository.GetTeamMembersByID(request.Id);
            if (memberToUpdate == null)
            {
                _logger.LogInformation("Member not found for Member ID:" + request.Id);
                throw new NotFoundException(nameof(TeamMember), request.Id);
            }
            _mapper.Map(request, memberToUpdate, typeof(UpdateTeamMemberCommand), typeof(TeamMember));
            await _memberRepository.UpdateAsync(memberToUpdate);
            _logger.LogInformation("Member update successfull");
            return memberToUpdate.Id;
        }
    }
}
