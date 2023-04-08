﻿using AutoMapper;
using Member.Application.Features.Members.Commands.AddTeamMember;
using Member.Application.Features.Members.Queries.GetMembersList;
using Member.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TeamMember, TeamMemberVm>().ReverseMap();
            CreateMap<TeamMember, AddTeamMemberCommand>().ReverseMap();
        }
    }
}
