using Member.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Domain.Entities
{
    public class TeamMember: EntityBase
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
