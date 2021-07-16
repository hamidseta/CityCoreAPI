using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfoApi.Models;

namespace CityInfoApi
{
	public class CityDataSource
	{
		public List<CityDto> Cities { get; set; }

		public CityDataSource()
		{
			Cities = new List<CityDto>
			{
				new CityDto
				{
					Id =1, Name ="Ahmedabad", Descrption="A big city in gujarat state"
				},
				new CityDto
				{
					Id =2, Name ="Delhi", Descrption="A Captital of India"
				},
				new CityDto
				{
					Id =3, Name ="Gandhinagar", Descrption="A Captital of Gujarat state"
				},
				new CityDto
				{
					Id =4, Name ="Mumbai", Descrption="Hub of bollywood"
				}
			};
		}
	}
}
