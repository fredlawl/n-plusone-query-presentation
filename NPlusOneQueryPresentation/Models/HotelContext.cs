using Microsoft.EntityFrameworkCore;

namespace Models
{
	public class HotelContext : DbContext
	{
		public HotelContext(DbContextOptions<HotelContext> options) : base(options)
		{
			
		}
		
		public DbSet<Bed> Beds { get; set; }
		public DbSet<Hotel> Hotels { get; set; }
		public DbSet<Inkeeper> Inkeepers { get; set; }
		public DbSet<HotelRoom> HotelRooms { get; set; }
		public DbSet<RoomFeature> RoomFeatures { get; set; }
		public DbSet<HotelRoomName> HotelRoomNames { get; set; }
		public DbSet<HotelInkeeper> HotelInkeepers { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<HotelRoomName>(entity =>
			{
				entity.Property(hrn => hrn.NameOfRoom)
					.HasColumnName("HotelRoomName");
				entity.HasKey(hrn => new
				{
					hrn.HotelId, hrn.HotelRoomId
				});
			});

			modelBuilder.Entity<HotelInkeeper>(entity =>
			{
				entity.ToTable("HotelInkeeper");
				entity.HasKey(hi => new { hi.HotelId, hi.InkeeperId });
				entity.HasOne<Hotel>(hi => hi.Hotel)
					.WithMany(h => h.HotelInkeepers)
					.HasForeignKey(hi => hi.HotelId);
				entity.HasOne<Inkeeper>(hi => hi.Inkeeper)
					.WithMany(i => i.HotelInkeepers)
					.HasForeignKey(hi => hi.InkeeperId);
			});

			modelBuilder.Entity<HotelRoom>(entity =>
			{
				entity.HasKey(hr => hr.HotelId);
				entity.HasOne(hi => hi.Hotel)
					.WithMany(h => h.HotelRooms)
					.HasForeignKey(hr => hr.HotelId);
			});
		}
	}
}
