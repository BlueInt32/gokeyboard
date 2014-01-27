using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Tools;

namespace GoKeyboardRest.Api.Controllers
{
    public class YoController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.message = string.Empty;
            bool resultTest = TestConnection("System.Data.SqlClient", @"SRV-SQL004\SQLMUTU", "journeymgok", "journeymgok", "u8pjdF69t8vN", false);
                ViewBag.result = resultTest;
            return View();
        }


        public bool TestConnection(string provider, string serverName, string initialCatalog, string userId, string password, bool integratedSecurity)
        {
            var canConnect = false;

            var connectionString = integratedSecurity ? string.Format("Provider={0};Data Source={1};Initial Catalog={2};Integrated Security=SSPI;", provider, serverName, initialCatalog)
                                                      : string.Format("Provider={0};Data Source={1};Initial Catalog={2};User ID={3};Password={4};", provider, serverName, initialCatalog, userId, password);
            //var connection
            //var connection = new OleDbConnection(connectionString);

            try
            {
                using (connection)
                {
                    connection.Open();

                    canConnect = true;
                }
            }
            catch (Exception exception)
            {
                StringBuilder sb = new StringBuilder();
                Exception currentException = exception;
                sb.AppendLine(currentException.Message);
                //Log.Error("TestConnect", currentException.Message + " --- " + currentException.StackTrace);
                while (currentException.InnerException != null)
                {
                    currentException = currentException.InnerException;
                    sb.AppendLine(currentException.Message);
                    //Log.Error("TestConnect", currentException.Message + " --- " + currentException.StackTrace);
                }
                ViewBag.message = sb.ToString();
            }
            finally
            {
                connection.Close();
            }

            return canConnect;
        }
	}
}