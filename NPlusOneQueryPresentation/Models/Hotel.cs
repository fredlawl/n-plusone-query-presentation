using System;
using System.Collections.Generic;

namespace Models
{
	public class Hotel
	{
		public int Id { get; set; }
		public Guid Uid { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }

		public virtual ICollection<HotelInkeeper> HotelInkeepers { get; set; }
		
		public virtual ICollection<HotelRoom> HotelRooms { get; set; }
		
		private Hotel()
		{
			Id = 0;
			Uid = Guid.NewGuid();
			HotelRooms = new List<HotelRoom>();
			HotelInkeepers = new List<HotelInkeeper>();
		}
		
		public Hotel(string name, string phoneNumber) : this()
		{
			Name = name;
			PhoneNumber = phoneNumber;
		}
	}
}
