using Member.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Infrastructure.Persistence
{
    public class MemberContextSeed
    {
        public static async Task SeedAsync(MemberContext memberContext, ILogger<MemberContextSeed> logger)
        {
            if (!memberContext.teamMembers.Any())
            {
                await memberContext.teamMembers.AddRangeAsync(GetTeamMembersDefaultSeed());
                logger.LogInformation("Seed database associated with context {DBContextName}", typeof(MemberContext).Name);
            }
        }
        private static IEnumerable<TeamMember> GetTeamMembersDefaultSeed()
        {
            return new List<TeamMember>()
            {
                new TeamMember
                {
                    AdditionalDescription = "very good team worker",
                    AllocationPercentage = 30,
                    Name = "subhasis sarkar",
                    YearOfExperience = 11,
                    SkillSet = "dotnet,c#,MVC,WEB API",
                    ProjectStartDate = DateTime.Now.AddDays(-20),
                    ProjectEndDate = DateTime.Now.AddDays(30)
                },
                new TeamMember
                {
                    AdditionalDescription = "very good skilled performer",
                    AllocationPercentage = 30,
                    Name = "dibyajyoti das",
                    YearOfExperience = 6,
                    SkillSet = "dotnet,WEB API",
                    ProjectStartDate = DateTime.Now.AddDays(-20),
                    ProjectEndDate = DateTime.Now.AddDays(30)
                }
            };
        }
    }
}
