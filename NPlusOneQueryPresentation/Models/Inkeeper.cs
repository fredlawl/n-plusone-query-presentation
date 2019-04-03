using System;
using System.Collections.Generic;

namespace Models
{
	public class Inkeeper
	{
		public int Id { get; set; }
		public Guid Uid { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		public virtual ICollection<HotelInkeeper> HotelInkeepers { get; set; }

		private Inkeeper()
		{
			Id = 0;
			Uid = Guid.NewGuid();
		}
	}
}
