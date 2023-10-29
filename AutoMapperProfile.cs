using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using tutorial.DTO.Character;

namespace tutorial{
    public class AutoMapperProfile : Profile{
        public AutoMapperProfile(){
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDTO, Character>();
        }
    }
}