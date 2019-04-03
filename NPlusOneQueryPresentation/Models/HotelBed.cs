namespace Models
{
	public class HotelBed
	{
		public int HotelRoomId { get; set; }
		public HotelRoom Room { get; set; }
		public int BedId { get; set; }
		public Bed Bed { get; set; }

		private HotelBed()
		{
			
		}
	}
}
