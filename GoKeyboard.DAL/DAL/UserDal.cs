using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;

namespace GoKeyboard.DAL
{
	public class UserDal
	{

		public User Create(User inputObject)
		{
			using (GoKeyboardDbContext context = new GoKeyboardDbContext())
			{
                context.Users.Add(inputObject);
				context.SaveChanges();
				return inputObject;
			}
		}

		public User Retrieve(int id)
		{
			using (GoKeyboardDbContext context = new GoKeyboardDbContext())
			{
				User UserFromDb = context.Users.Where(u => u.Id == id).FirstOrDefault();

				return UserFromDb;
			}
		}

		public User Update(User inputObject)
		{
			using (GoKeyboardDbContext context = new GoKeyboardDbContext())
			{
                context.Users.Attach(inputObject);
				context.Entry(inputObject).State = EntityState.Modified;
				
					context.SaveChanges();
					return inputObject;
			}
		}

		public void Delete(int id)
		{
			using (GoKeyboardDbContext context = new GoKeyboardDbContext())
			{
				User UserFromDb = context.Users.Where(u => u.Id == id).FirstOrDefault();
				if (UserFromDb == null)
					throw new KeyboardDalException("Utilisateur introuvable en base de données");
                context.Users.Remove(UserFromDb);
				context.SaveChanges();
			}
		}

		public User GetUserByEmail(string email)
		{
			using (GoKeyboardDbContext context = new GoKeyboardDbContext())
			{
                User userFromDb = context.Users.Where(u => u.Email == email).FirstOrDefault();
				return userFromDb;
			}
		}
	}
}
