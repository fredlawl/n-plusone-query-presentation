using System.Collections.Generic;

namespace Models
{
	public interface IHotelRepository
	{
		Hotel GetHotelById(int id);
		IEnumerable<Hotel> GetAllHotels();
		IEnumerable<HotelRoom> GetHotelRooms(int hotelId);
		IEnumerable<HotelRoomName> GetHotelRoomNames();
	}
}
