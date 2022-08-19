using INF272_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Bio()
        {
            List<Influencers> influencers = getInfluencerData();
            return View(influencers);
            
        }
        private List<Influencers> getInfluencerData()
        {
            List<Influencers> influencers = new List<Influencers>();
            Influencers influencer1 = new Influencers(01, "Arianna", "Huufington", "Cambridge University", "USA", 10146816, "https://media-exp1.licdn.com/dms/image/C4D03AQHmPuoZ-4Jh6w/profile-displayphoto-shrink_200_200/0/1602549159611?e=1666224000&v=beta&t=S_MzpOU_7-P-HnEoxGuKNb74CAWo8jg4V0GPwpwTdA4)");
            Influencers influencer2 = new Influencers(02, "Jack", "Welch", "University of Illinois", "USA", 7159022, "https://media-exp1.licdn.com/dms/image/C4D03AQEnLkMsVAS1OQ/profile-displayphoto-shrink_200_200/0/1517246507753?e=1666224000&v=beta&t=LGYLzRL_iPCQ3GXPK-17NNVHWfOMJmw81vBDaBy3F08)");
            Influencers influencer3 = new Influencers(03, "Katya", "Andresen", "Haverford College", "USA", 1259640, "https://media-exp1.licdn.com/dms/image/D4D03AQHfYYPgpJF3vQ/profile-displayphoto-shrink_200_200/0/1642799999341?e=1666224000&v=beta&t=WVGu4cQJpXkeEkhdgkRTEU7tmdUJbE-oeTAVU1NRfhQ)");
            Influencers influencer4 = new Influencers(04, "Richard", "Brandson", "Stowe School", "USA", 19762851, "https://media-exp1.licdn.com/dms/image/C4D03AQHh6_Wth5f3rQ/profile-displayphoto-shrink_200_200/0/1625181962692?e=1666224000&v=beta&t=qGBswbQmsO-9sux0nRY_WSnH8cZNwDg_IWHokkzW4bg)");

            influencers.Add(influencer1);
            influencers.Add(influencer2);
            influencers.Add(influencer3);
            influencers.Add(influencer4);

            return influencers;

        }

        public ActionResult Stories()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Donations()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Volunteer()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}