using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GolBet.Entities;
using GolBet.Services.DTOs;

namespace GolBet.Services.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Match, MatchDto>();
        CreateMap<Team, TeamDto>();
        CreateMap<TeamFormDto, Team>().ReverseMap();
        CreateMap<MatchFormDto, Match>().ReverseMap();
        CreateMap<Match, MatchDetailDto>().ForMember(dto => dto.TotalBets, options => options.MapFrom(match => match.Bets.Count));
    }
}

