using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Features.Members.Commands.UpdateTeamMember
{
    public class UpdateTeamMemberCommandValidator : AbstractValidator<UpdateTeamMemberCommand>
    {
        public UpdateTeamMemberCommandValidator()
        {
            RuleFor(p => p.AdditionalDescription)
                .NotEmpty().WithMessage("{AdditionalDescription} is required")
                .NotNull().WithMessage("{AdditionalDescription} is required");

            RuleFor(p => p.AllocationPercentage)
                .NotEmpty().WithMessage("{AllocationPercentage} is required")
                .NotNull().WithMessage("{AllocationPercentage} is required")
                .LessThanOrEqualTo(100).WithMessage("AllocationPercentage should be provided as percentage");

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{Name} is required")
                .NotNull().WithMessage("{Name} is required");

            RuleFor(p => p.ProjectEndDate)
                .NotEmpty().WithMessage("{ProjectEndDate} is required")
                .NotNull().WithMessage("{ProjectEndDate} is required")
                .GreaterThan(p => p.ProjectStartDate).WithMessage("Project end date should be greaten than Project start date");

            RuleFor(p => p.ProjectStartDate)
                .NotEmpty().WithMessage("{ProjectStartDate} is required")
                .NotNull().WithMessage("{ProjectStartDate} is required");

            RuleFor(p => p.SkillSet)
                .NotEmpty().WithMessage("{SkillSet} is required")
                .NotNull().WithMessage("{SkillSet} is required");

            RuleFor(p => p.YearOfExperience)
                .NotEmpty().WithMessage("{YearOfExperience} is required")
                .NotNull().WithMessage("{YearOfExperience} is required")
                .GreaterThan(4).WithMessage("YearOfExperience should be greater than 4 years");
        }
    }
}
