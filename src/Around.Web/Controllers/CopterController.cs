﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Around.Core.Entities;
using Around.Core.Interfaces;
using Around.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Around.Web.Controllers
{
    [Route("api/[controller]")]
    public class CopterController : Controller
    {
        private readonly ICopterRepository _copterRepository;

        public CopterController(ICopterRepository copterRepository)
        {
            _copterRepository = copterRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCopter()
        {
            List<Copter> copters = await _copterRepository.GetAllAsync();
            var response = new List<CopterDto>();

            foreach (var copter in copters)
            {
                response.Add(new CopterDto(copter));
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCopter(int id)
        {
            return Json(await _copterRepository.Get(id));
        }

        [HttpPost]
        public IActionResult CreateCopter([FromBody] CopterAggregate copterDto)
        {
            var copter = new Copter().CreateFromDto(copterDto);
            _copterRepository.Create(copter);

            return Ok("Success");
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCopter(int id) => _copterRepository.Delete(id);

        [HttpPost]
        [Route("{id}")]
        public IActionResult UpdateCopter(int id, [FromBody] CopterAggregate copterDto)
        {
            var copter = new Copter().CreateFromDto(copterDto);
            _copterRepository.Update(id, copter);

            return Ok("Success");
        }
    }
}
