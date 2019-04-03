using System;

namespace Models
{
	public class HotelInkeeper
	{
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }
		public int InkeeperId { get; set; }
		public Inkeeper Inkeeper { get; set; }
		public DateTime HiredOn { get; set; }

		private HotelInkeeper()
		{
			
		}
	}
}
