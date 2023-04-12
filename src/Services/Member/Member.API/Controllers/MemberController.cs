using MediatR;
using Member.Application.Features.Members.Commands.AddTeamMember;
using Member.Application.Features.Members.Commands.UpdateTeamMember;
using Member.Application.Features.Members.Queries.GetMembersList;
using Member.Application.Features.Members.Queries.GetMemberTaskList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Member.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MemberController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("{MemberId}", Name = "GetTeamMemberByID")]
        [ProducesResponseType(typeof(IEnumerable<TeamMemberVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<TeamMemberVm>>> GetTeamMemberVmByUserName(int MemberId)
        {
            var query = new GetMemberListQuery(MemberId);
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }

        [HttpGet("{MemberId}", Name = "GetTaskListByMemberID")]
        [ProducesResponseType(typeof(IEnumerable<MemberTaskVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<MemberTaskVm>>> GetTaskListByMemberID(int MemberId)
        {
            var query = new GetMemberTaskListQuery(MemberId);
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }

        [HttpPut(Name = "AddTeamMember")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> AddTeamMember([FromBody] AddTeamMemberCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut(Name = "UpdateTeamMember")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateTeamMember([FromBody] UpdateTeamMemberCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
