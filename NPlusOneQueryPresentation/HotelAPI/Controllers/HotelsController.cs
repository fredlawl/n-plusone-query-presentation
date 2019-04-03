using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace HotelAPI.Controllers
{
	[Route("api/[controller]")]
	public class HotelsController : Controller
	{
		private IHotelRepository _hotelRepository;
		
		public HotelsController(IHotelRepository hotelRepository)
		{
			_hotelRepository = hotelRepository;
		}
		
		[HttpGet]
		public IEnumerable<Hotel> Get()
		{
			var hotels = _hotelRepository.GetAllHotels();
			return hotels;
		}
	}
}
