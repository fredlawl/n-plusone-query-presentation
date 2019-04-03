using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Optimizations
{
	public class HotelRepository : IHotelRepository
	{
		private readonly HotelContext _context;
		
		public HotelRepository(HotelContext context)
		{
			_context = context;
		}

		public Hotel GetHotelById(int id)
		{
			return _context.Hotels
				.FirstOrDefault(h => h.Id == id);
		}

		public IEnumerable<Hotel> GetAllHotels()
		{
			return _context.Hotels
				.Include(h => h.HotelInkeepers)
				.ThenInclude(h => h.Inkeeper)
				.Include(h => h.HotelRooms);
		}

		public IEnumerable<HotelRoom> GetHotelRooms(int hotelId)
		{
			return _context.HotelRooms.Where(hr => hr.HotelId == hotelId)
				.Include(hr => hr.Hotel);
		}

		public IEnumerable<HotelRoomName> GetHotelRoomNames()
		{
			return _context.HotelRoomNames;
		}
	}
}
