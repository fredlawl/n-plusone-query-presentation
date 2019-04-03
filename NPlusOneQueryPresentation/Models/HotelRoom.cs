using System;

namespace Models
{
	public class HotelRoom
	{
		public int Id { get; set; }
		public Guid Uid { get; set; }
		public string Name { get; set; }
		public int NumOfRooms { get; set; }
		public decimal CostPerNight { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }

		private HotelRoom()
		{
			Id = 0;
			Uid = Uid = Guid.NewGuid();
		}
	}
}
