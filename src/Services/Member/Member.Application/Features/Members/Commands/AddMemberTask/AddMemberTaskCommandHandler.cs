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

namespace Member.Application.Features.Members.Commands.AddMemberTask
{
    public class AddMemberTaskCommandHandler : IRequestHandler<AddMemberTaskCommand, int>
    {
        private readonly IMemberTaskRepository _memberTaskRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddMemberTaskCommandHandler> _logger;
        public async Task<int> Handle(AddMemberTaskCommand request, CancellationToken cancellationToken)
        {
            var newTask =_mapper.Map<MemberTask>(request);
            var taskResult = await _memberTaskRepository.AddAsync(newTask);
            _logger.LogInformation("New task added. Task Id: " + taskResult.Id);
            return taskResult.Id;
        }
    }
}
