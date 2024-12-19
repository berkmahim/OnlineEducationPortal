using AutoMapper;
using EduPortal.Business.Abstract;
using EduPortal.DTO.DTOs.AboutDTOs;
using EduPortal.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _aboutService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        { 
            var values = _aboutService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        { 
            var value = _aboutService.TGetbyId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Silme işlemi başarılı");
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreate(value);
            return Ok("ekleme işlemi başarılı");

        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("güncelleme işlemi başarılı");
        }

    }
}
