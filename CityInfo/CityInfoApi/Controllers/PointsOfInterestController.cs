using CityInfoApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi.Controllers
{
	[ApiController]
	[Route("api/cities/{cityid}/pointofinterest")]
	public class PointsOfInterestController : ControllerBase
	{
		[HttpGet("random")]
		public IActionResult Get()
		{
			return Ok(new PointsOfInterestDto
			{
				Id=new Random().Next(100),
				Name="Hamid",
				Description="Test"
			});
		}

		[HttpPost]
		public IActionResult CreatePointOfInterest(PointsOfInterestDto pointsOfInterest)
		{
			if (pointsOfInterest == null)
			{

			}

			return Ok( new PointsOfInterestDto
			{
				Id = new Random().Next(100),
				Name = pointsOfInterest.Name,
				Description = pointsOfInterest.Description
			});
		}
	}
}
