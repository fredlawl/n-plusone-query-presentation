using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace HotelAPI.Controllers
{
	[Route("api/hotels/[controller]")]
	public class RoomNamesController
	{
		private IHotelRepository _hotelRepository;
		
		public RoomNamesController(IHotelRepository hotelRepository)
		{
			_hotelRepository = hotelRepository;
		}
		
		[HttpGet]
		public IEnumerable<HotelRoomName> Get()
		{
			return _hotelRepository.GetHotelRoomNames();
		}
	}
}