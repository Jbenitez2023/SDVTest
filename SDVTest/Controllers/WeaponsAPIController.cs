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
    public class WeaponsAPIController : ControllerBase
    {
        private readonly SDVContext _context;
        IMapper _mapper;
        ResponseDto _responseDto;

        public WeaponsAPIController(SDVContext context, IMapper mapper)
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
                IEnumerable<Weapons> list = _context.Weapons.Include(p => p.Professions).ToList();
                IEnumerable<WeaponsDto> obj = _mapper.Map<IEnumerable<WeaponsDto>>(list);
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
                Weapons list = _context.Weapons.Where(d=> d.Id == Id).Include(d => d.Professions).FirstOrDefault();
                WeaponsDto obj = _mapper.Map<WeaponsDto>(list);
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

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] WeaponsDto model)
        {
            try
            {
                Weapons weapon = _mapper.Map<Weapons>(model);
                _context.Weapons.Add(weapon);

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
        public async Task<ResponseDto> Put([FromBody] WeaponsDto model)
        {

            try
            {
                Weapons weapons = _mapper.Map<Weapons>(model);
                _context.Weapons.Update(weapons);

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

                Weapons weapons = _context.Weapons.Find(Id);
                _context.Weapons.Remove(weapons);

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
