using System;
using System.Collections.Generic;
using Models.ActiveRecord;

namespace HotelAPI.Controllers
{
	public class ActiveRecordController
	{	
		private static class Session
		{
			public static void StoreUser(User user)
			{
				
			}
		}

		private class AuthenticationService
		{
			public User Authenticate(string email, string password)
			{
				var user = User.GetByEmailAddress(email);
				if (user == null)
					throw new Exception("Username not found.");
			
				if (!user.Authenticate(password))
					throw new Exception("Username password mismatch.");

				return user;
			}
		}
		
		public void Login(string emailAddress, string password)
		{
			var authenticator = new AuthenticationService();
			var user = authenticator.Authenticate(emailAddress, password);
			var isAdmin = user.HasRole(RoleType.Admin);
			
			if (isAdmin)
				Session.StoreUser(user);
		}

		public IEnumerable<User> ListAdminUsers()
		{
			var result = new List<User>();
			var users = User.GetAll();

			foreach (var user in users)
			{
				if (user.HasRole(RoleType.Admin))
					result.Add(user);
			}

			return result;
		}
	}
}
