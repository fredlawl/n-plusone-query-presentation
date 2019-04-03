using System.Collections.Generic;
using System.Linq;

namespace Models.ActiveRecord
{
	public class User
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public IEnumerable<Role> Roles { get; set; }
		private string HashedPassword { get; set; }

		public static IEnumerable<User> GetAll()
		{
			// SELECT * FROM Users
			return new List<User>();
		}

		public static User GetByEmailAddress(string email)
		{
			// SELECT * FROM User WHERE email = email; 
			return new User();
		}

		public bool Authenticate(string password)
		{
			// hash(password) == HashedPassword
			return true;
		}

		public bool HasRole(RoleType roleType)
		{
			Roles = GetRoles();
			return Roles.First(r => r.Type == roleType) != null;
		}

		public IEnumerable<Role> GetRoles()
		{
			// SELECT * FROM Roles WHERE UserId = this.Id
			return new List<Role>();
		}
	}
	
	public enum RoleType
	{
		Admin,
		User
	}
	
	public class Role
	{
		public RoleType Type { get; set; }
	}
}
