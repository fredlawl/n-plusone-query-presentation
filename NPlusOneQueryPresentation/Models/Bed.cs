using System;

namespace Models
{
	public class Bed
	{
		public int Id { get; set; }
		public Guid Uid { get; set; }
		public string Name { get; set; }
		public int Sleeps { get; set; }

		private Bed()
		{
			Id = 0;
			Uid = Guid.NewGuid();
		}
	}
}
