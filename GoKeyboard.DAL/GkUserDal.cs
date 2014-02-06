using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;
using Tools;
using Tools.EntityFramework;
using Tools.Orm;

namespace GoKeyboard.DAL
{
	public class GkUserDal : Crud<GkUser, int>
	{
		#region Implementation of IRepository<GkUser,in string>

		public OperationResult<GkUser> Create(GkUser inputObject)
		{
			using (DataContext context = new DataContext())
			{
                context.GkUsers.Add(inputObject);
				IEnumerable<DbEntityValidationResult> errors = context.GetValidationErrors();
				if (errors.Count() > 0)
					return OperationResult<GkUser>.BadResultWithList("Erreur(s) de validation pour la création, voir ErrorList", errors.FormatValidationErrorList());

				int nbSaved = context.SaveChanges();
				return nbSaved != 1 ? OperationResult<GkUser>.BadResult("GkUser non créé", inputObject) : OperationResult<GkUser>.OkResultInstance(inputObject);
			}
		}

		public OperationResult<GkUser> Retrieve(int id)
		{
			using (DataContext context = new DataContext())
			{
				GkUser UserFromDb = context.GkUsers.Where(u => u.Id == id).FirstOrDefault();
				if (UserFromDb == null)
					return OperationResult<GkUser>.BadResult("GkUser introuvable");
				return OperationResult<GkUser>.OkResultInstance(UserFromDb);
			}
		}

		public OperationResult<GkUser> Update(GkUser inputObject)
		{
			using (DataContext context = new DataContext())
			{
                context.GkUsers.Attach(inputObject);
					var entry = context.Entry(inputObject);
					entry.State = EntityState.Modified;

					IEnumerable<DbEntityValidationResult> errors = context.GetValidationErrors();
					if (errors.Count() > 0)
						return OperationResult<GkUser>.BadResultWithList("Erreur(s) de validation pour la création, voir ErrorList", errors.FormatValidationErrorList());
				
					context.SaveChanges();
					return OperationResult<GkUser>.OkResultInstance(inputObject);
			}
		}

		public OperationResult<GkUser> Delete(int id)
		{
			using (DataContext context = new DataContext())
			{
				GkUser UserFromDb = context.GkUsers.Where(u => u.Id == id).FirstOrDefault();
				if (UserFromDb == null)
					return OperationResult<GkUser>.BadResult("GkUser introuvable");
                context.GkUsers.Remove(UserFromDb);
				if (context.SaveChanges() != 1)
					return OperationResult<GkUser>.BadResult("GkUser non supprimé", UserFromDb);
				else
					return OperationResult<GkUser>.OkResult;
			}
		}
		#endregion

		public GkUser GetUserByEmail(string email)
		{
			using (DataContext context = new DataContext())
			{
                GkUser userFromDb = context.GkUsers.Where(u => u.Email == email).FirstOrDefault();
				return userFromDb;
			}
		}

        //public OperationResult<List<GkUser>> ExtractUsers()
        //{
        //    using (DataContext context = new DataContext())
        //    {
        //        try
        //        {
        //            List<GkUser> participationsFromDb = context.GkUsers.Include("ShowType").Include("ConnexionType").OrderByDescending(u => u.CreationDate).ToList();
        //            return OperationResult<List<GkUser>>.OkResultInstance(participationsFromDb);
        //        }
        //        catch (Exception e)
        //        {
        //            return OperationResult<List<GkUser>>.BadResult("Echec de la récupération des utilisateurs : " + e.Message);
        //        }
        //    }
        //}

        /// <summary>
        /// Methode pour le back
        /// </summary>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        //public OperationResult<List<GkUser>> ExtractUsersWithDateLapsTime(DateTime debut, DateTime fin)
        //{
        //    using (var context = new DataContext())
        //    {
        //        try
        //        {
        //            List<GkUser> participationsFromDb = context.GkUsers.Include("ShowType").Include("ConnexionType").Where(u => u.CreationDate >= debut && u.CreationDate <= fin).OrderByDescending(u => u.CreationDate).ToList();
        //            return OperationResult<List<GkUser>>.OkResultInstance(participationsFromDb);
        //        }
        //        catch (Exception e)
        //        {
        //            return OperationResult<List<GkUser>>.BadResult("Echec de la récupération des utilisateurs : " + e.Message);
        //        }
        //    }
        //}
	}
}
