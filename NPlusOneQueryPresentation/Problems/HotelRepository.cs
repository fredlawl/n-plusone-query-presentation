using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Models;

namespace Problems
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
			throw new System.NotImplementedException();
		}

		public IEnumerable<Hotel> GetAllHotels()
		{
			var hotels = _context.Hotels.Take(500).ToList();
			foreach (var hotel in hotels)
			{
				var hotelInkeepers = GetHotelInkeepersByHotelId(hotel.Id).ToList();
				foreach (var hotelInkeeper in hotelInkeepers)
				{
					hotelInkeeper.Inkeeper = GetInkeeperById(hotelInkeeper.InkeeperId);
				}

				hotel.HotelInkeepers = hotelInkeepers;
				hotel.HotelRooms = GetHotelRoomsByHotelId(hotel.Id).ToList();
			}

			return hotels;
		}

		public IEnumerable<HotelRoom> GetHotelRooms(int hotelId)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<HotelRoomName> GetHotelRoomNames()
		{
			return _context.HotelRoomNames;
		}

		private IEnumerable<HotelRoom> GetHotelRoomsByHotelId(int id)
		{
			return _context.HotelRooms.Where(hr => hr.Id == id);
		}

		private Inkeeper GetInkeeperById(int id)
		{
			return _context.Inkeepers.FirstOrDefault(i => i.Id == id);
		}

		private IEnumerable<HotelInkeeper> GetHotelInkeepersByHotelId(int id)
		{
			return _context.HotelInkeepers.Where(hi => hi.HotelId == id);
		}
	}
}
