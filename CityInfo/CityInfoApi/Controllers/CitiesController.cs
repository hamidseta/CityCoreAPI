using CityInfoApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi.Controllers
{
	[ApiController]
	public class CitiesController : ControllerBase
	{
		[HttpGet("api/cities")]
		public JsonResult GetCities()
		{
			return new JsonResult(
				new CityDataSource().Cities
			);
		}

		[HttpGet("api/cities/{id}", Name = "GetCity")]
		public JsonResult GetCity(int id)
		{
			return new JsonResult(
				new CityDataSource().Cities.FirstOrDefault(c => c.Id == id)
			);
		}

		[HttpPost("api/cities/create")]
		public IActionResult Create(CityDto city)
		{
			if (city == null)
			{
				return BadRequest();
			}

			return Ok(city);
		}

		[HttpPut("api/cities/update/{id}")]
		public IActionResult UpdateCity(int cityId,[FromBody] CityDto city)
		{
			if (city == null)
			{
				return BadRequest();
			}

			return Ok(city);
		}
	}
}
