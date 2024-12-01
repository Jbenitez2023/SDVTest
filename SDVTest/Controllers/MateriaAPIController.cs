using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDVTest.Context;
using SDVTest.Dto;
using SDVTest.Models;

namespace SDVTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaAPIController : ControllerBase
    {
        private readonly SDVContext _context;
        IMapper _mapper;
        ResponseDto _responseDto;

        public MateriaAPIController(SDVContext context, IMapper mapper)
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
                IEnumerable<Materia> list = _context.Materias.ToList();
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
                Materia list = _context.Materias.Find(Id);
                _responseDto.result = list;
                _responseDto.isSucces = true;
                _responseDto.Messages = "finded";
            }
            catch (Exception ex)
            {

                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error: {ex.Message}.";
            }

            return _responseDto;
        }

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] MateriaDto model)
        {

            try
            {
                Materia materia = _mapper.Map<Materia>(model);
                _context.Materias.Add(materia);

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
        public async Task<ResponseDto> Put([FromBody] MateriaDto model)
        {

            try
            {
                Materia materia = _mapper.Map<Materia>(model);
                _context.Materias.Update(materia);

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

                Materia materia = _context.Materias.Find(Id);
                _context.Materias.Remove(materia);

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
