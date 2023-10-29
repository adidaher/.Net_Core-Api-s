
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial.DTO.Character;
using tutorial.Models;
namespace tutorial.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDTO>> getCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
    }

}