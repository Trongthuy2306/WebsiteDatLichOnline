using DocTorOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocTorOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Introduce()
        {
            return View();
        }
        public ActionResult Services()
        {
            List<dichvu> lsdv = new List<dichvu>();
            var dv = new dichvu();
            dv.img = "http://3.bp.blogspot.com/-vugJVgyECIM/VbAEw0OGrkI/AAAAAAAADls/5KKVlWo4dm8/s1600/doctor5.jpg";
            dv.name = "Nguyen Van A";
            var dv2 = new dichvu();
            dv2.img = "http://3.bp.blogspot.com/-vugJVgyECIM/VbAEw0OGrkI/AAAAAAAADls/5KKVlWo4dm8/s1600/doctor5.jpg";
            dv2.name = "Nguyen Van A";
            var dv3 = new dichvu();
            dv3.img = "http://3.bp.blogspot.com/-vugJVgyECIM/VbAEw0OGrkI/AAAAAAAADls/5KKVlWo4dm8/s1600/doctor5.jpg";
            dv3.name = "Nguyen Van A";
            var dv4 = new dichvu();
            dv4.img = "";
            dv4.name = "Nguyen Van A";
            lsdv.Add(dv);
            lsdv.Add(dv2);
            lsdv.Add(dv3);
            lsdv.Add(dv4);
            return View(lsdv);
        }
        public ActionResult dichvu()
        {
            List<dichvu>lsdv=new List<dichvu>();
            var dv = new dichvu();
            dv.img = "http://3.bp.blogspot.com/-vugJVgyECIM/VbAEw0OGrkI/AAAAAAAADls/5KKVlWo4dm8/s1600/doctor5.jpg";
            dv.name = "Nguyen Van A";
            var dv2 = new dichvu();
            dv2.img = "http://3.bp.blogspot.com/-vugJVgyECIM/VbAEw0OGrkI/AAAAAAAADls/5KKVlWo4dm8/s1600/doctor5.jpg";
            dv2.name = "Nguyen Van A";
            var dv3 = new dichvu();
            dv3.img = "http://3.bp.blogspot.com/-vugJVgyECIM/VbAEw0OGrkI/AAAAAAAADls/5KKVlWo4dm8/s1600/doctor5.jpg";
            dv3.name = "Nguyen Van A";
            var dv4 = new dichvu();
            dv4.img = "";
            dv4.name = "Nguyen Van A";
            lsdv.Add(dv);
            lsdv.Add(dv2);
            lsdv.Add(dv3);
            lsdv.Add(dv4);
            return View(lsdv);
        }
    }
}