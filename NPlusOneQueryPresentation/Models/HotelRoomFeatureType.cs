namespace Models
{
	public class HotelRoomFeatureType
	{
		public int HotelRoomId { get; set; }
		public HotelRoom HotelRoom { get; set; }
		public int RoomFeatureId { get; set; }
		public RoomFeature RoomFeature { get; set; }

		private HotelRoomFeatureType()
		{
			
		}
	}
}
