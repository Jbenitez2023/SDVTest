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
    public class VehiclesAPIController : ControllerBase
    {
        private readonly SDVContext _context;
        IMapper _mapper;
        ResponseDto _responseDto;

        public VehiclesAPIController(SDVContext context, IMapper mapper)
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
                IEnumerable<Vehicles> list = _context.Vehicles.ToList();
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
                Vehicles list = _context.Vehicles.Find(Id);
                _responseDto.result = list;
                _responseDto.isSucces = true;
                _responseDto.Messages = "Datos encontrados";
            }
            catch (Exception ex)
            {

                _responseDto.isSucces = false;
                _responseDto.Messages = $"Error al encontrar datos: {ex.Message}.";
            }

            return _responseDto;
        }

        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] VehiclesDto model)
        {

            try
            {
                Vehicles vehicles = _mapper.Map<Vehicles>(model);
                _context.Vehicles.Add(vehicles);

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
        public async Task<ResponseDto> Put([FromBody] Vehicles model)
        {

            try
            {
                Vehicles vehicles = _mapper.Map<Vehicles>(model);
                _context.Vehicles.Update(vehicles);

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

                Vehicles vehicles = _context.Vehicles.Find(Id);
                _context.Vehicles.Remove(vehicles);

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
