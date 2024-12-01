using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDVTest.Context;
using SDVTest.Dto;
using SDVTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SDVTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionAPIController : ControllerBase
    {
        private readonly SDVContext _context;
        IMapper _mapper;
        ResponseDto _responseDto;

        public ProfessionAPIController(SDVContext context, IMapper mapper)
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
                IEnumerable<Professions> list = _context.Professions.ToList();
                _responseDto.result = list;
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
                Professions list = _context.Professions.Find(Id);
                _responseDto.result = list;
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

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] ProfessionsDto model)
        {
            try
            {
                Professions professions = _mapper.Map<Professions>(model);
                _context.Professions.Add(professions);

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
        public async Task<ResponseDto> Put([FromBody] ProfessionsDto model)
        {

            try
            {
                Professions professions = _mapper.Map<Professions>(model);
                _context.Professions.Update(professions);

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

                Professions professions = _context.Professions.Find(Id);
                _context.Professions.Remove(professions);

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
