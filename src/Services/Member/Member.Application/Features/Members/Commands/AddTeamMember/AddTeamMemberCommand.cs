using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Commands.AddTeamMember
{
    public class AddTeamMemberCommand : IRequest<int>
    {
        public string Name { get; set; }
        public double YearOfExperience { get; set; }
        public string SkillSet { get; set; }
        public string AdditionalDescription { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public double AllocationPercentage { get; set; }

    }
}
