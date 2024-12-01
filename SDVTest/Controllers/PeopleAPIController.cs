using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDVTest.Context;
using SDVTest.Dto;
using SDVTest.Models;

namespace SDVTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleAPIController : ControllerBase
    {

        private readonly SDVContext _context;
        IMapper _mapper;
        ResponseDto _responseDto;

        public PeopleAPIController(SDVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _responseDto = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<People> list = _context.Peoples
                    .Include(p => p.Professions)
                    .Include(p => p.Weapons)
                    .Include(p => p.People_materia)
                    .ThenInclude(m => m.Materia)
                    .ToList();
                IEnumerable<PeopleDto> obj = _mapper.Map<IEnumerable<PeopleDto>>(list);
                _responseDto.result = obj;
                _responseDto.isSucces = true;
                _responseDto.Messages = "Finded";
            }
            catch (Exception ex)
            {
                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error: {ex.Message}.";
            }

            return _responseDto;
        }

        [HttpGet]
        [Route("{Id:int}")]
        public ResponseDto Get(int Id)
        {
            try
            {
                People list = _context.Peoples.Where(p => p.Id == Id)
                    .Include(p => p.Professions)
                    .Include(p => p.Weapons)
                    .Include(p => p.People_materia)
                    .ThenInclude(m => m.Materia).FirstOrDefault();
                PeopleDto obj = _mapper.Map<PeopleDto>(list);
                _responseDto.result = obj;
                _responseDto.isSucces = true;
                _responseDto.Messages = "Finded";
            }
            catch (Exception ex)
            {

                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error : {ex.Message}.";
            }

            return _responseDto;
        }

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] PeopleDto model)
        {

            try
            {
                People people = _mapper.Map<People>(model);
                _context.Peoples.Add(people);

                _responseDto.result = await _context.SaveChangesAsync();
                _responseDto.isSucces = true;
                _responseDto.Messages = "Saved";
            }
            catch (Exception ex)
            {
                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error: {ex.Message}.";
            }

            return _responseDto;

        }

        [HttpPost]
        [Route("AdMateria")]
        public async Task<ResponseDto> Post([FromBody] PeopleMateriaDto model)
        {

            try
            {
                People_Materia peopleMateria = _mapper.Map<People_Materia>(model);
                _context.Add(peopleMateria);

                _responseDto.result = await _context.SaveChangesAsync();
                _responseDto.isSucces = true;
                _responseDto.Messages = "Saved";
            }
            catch (Exception ex)
            {
                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error: {ex.Message}.";
            }

            return _responseDto;

        }

        [HttpPut]
        public async Task<ResponseDto> Put([FromBody] PeopleDto model)
        {

            try
            {
                People people = _mapper.Map<People>(model);
                _context.Peoples.Update(people);

                _responseDto.result = await _context.SaveChangesAsync();
                _responseDto.isSucces = true;
                _responseDto.Messages = "Saved";
            }
            catch (Exception ex)
            {

                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error : {ex.Message}.";
            }

            return _responseDto;

        }

        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<ResponseDto> Delete(int Id)
        {
            try
            {

                People people = _context.Peoples.Find(Id);
                _context.Peoples.Remove(people);

                _responseDto.result = await _context.SaveChangesAsync();
                _responseDto.isSucces = true;
                _responseDto.Messages = "Deleted";
            }
            catch (Exception ex)
            {

                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error : {ex.Message}.";
            }

            return _responseDto;

        }

        [HttpDelete]
        [Route("removeMateria/{IdPeopleMateria:int}")]
        public async Task<ResponseDto> Delete(string IdPeopleMateria)
        {
            try
            {
               
                People_Materia people = _context.peopleMateria.Find(Convert.ToInt32(IdPeopleMateria));
                _context.peopleMateria.Remove(people);

                _responseDto.result = await _context.SaveChangesAsync();
                _responseDto.isSucces = true;
                _responseDto.Messages = "Deleted";
            }
            catch (Exception ex)
            {

                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error : {ex.Message}.";
            }

            return _responseDto;

        }

        
    }
}
