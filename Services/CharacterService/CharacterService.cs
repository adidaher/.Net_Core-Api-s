
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial.DTO.Character;
using tutorial.Models;
using AutoMapper;
namespace tutorial.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id =1 , Name = "Sam" }
        };

        private readonly IMapper mapper;

        public CharacterService(IMapper mapper){
            this.mapper = mapper;
        }
        
        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            var character = mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c=>c.Id)+1;
            characters.Add(character);
            serviceResponse.Data = characters.Select(c => mapper.Map<GetCharacterDTO>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            serviceResponse.Data = characters.Select(c => mapper.Map<GetCharacterDTO>(c)).ToList();
           return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> getCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDTO>();
            var character = characters.FirstOrDefault(c=>c.Id == id);
            serviceResponse.Data = mapper.Map<GetCharacterDTO>(character);
            return serviceResponse;
            
        }
    }

}