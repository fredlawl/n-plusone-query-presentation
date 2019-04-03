using System;

namespace Models
{
	public class RoomFeature
	{
		public int Id { get; set; }
		public Guid Uid { get; set; }
		public string Feature { get; set; }

		private RoomFeature()
		{
			Id = 0;
			Uid = Guid.NewGuid();
		}
	}
}
