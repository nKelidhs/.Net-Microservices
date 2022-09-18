using AutoMapper;
using PlatformService.DTO;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.AutoMapper
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source  ->  Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
