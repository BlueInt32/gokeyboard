using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoKeyboard.DAL;
using GoKeyboard.DTO;
using Tools;
using System.Net.NetworkInformation;
using System.Text;
using GoKeyboard.Business;

namespace GoKeyboardRest.Api.Controllers
{
    public class HomeController : Controller
	{
		public double PingTimeAverage(string host, int echoNum)
		{
			StringBuilder sb = new StringBuilder();

			long totalTime = 0;
			int timeout = 120;
			Ping pingSender = new Ping();

			for (int i = 0; i < echoNum; i++)
			{
				PingReply reply = pingSender.Send(host, timeout);
				if (reply.Status == IPStatus.Success)
				{
					totalTime += reply.RoundtripTime;
					sb.AppendLine(reply.RoundtripTime.ToString());
				}
			}
			ViewBag.Info = sb.ToString();
			return totalTime / echoNum;
		}
        public ActionResult Index()
        {
			//ViewBag.PingTimeAverage =  PingTimeAverage("SRV-SQL004", 5);
            return View();
        }

        public ActionResult ChaptersList()
        {
            GkLessonDal gld = new GkLessonDal();
            List<GkChapter> list = gld.GetChapters();

            return View(list);
            

        }

        public ActionResult LessonsList(int id)
        {
            GkLessonDal gld = new GkLessonDal();
            List<GkLesson> list = gld.GetLessons(id);

            return View(list);
        }

        public ActionResult Lesson(int id)
        {
	        GkLessonDal dal = new GkLessonDal();
			GkLesson lesson = dal.Retrieve(id).ReturnObject;
            LessonPageFactory lpFactory = new LessonPageFactory();
            OperationResult<GkLesson> building = lpFactory.BuildPages(lesson);

            return View(building.ReturnObject);
        }

	    public ActionResult Stats()
	    {
		    return View();
	    }

        public ActionResult Conseils()
        {
            return View();
        }
	}
}