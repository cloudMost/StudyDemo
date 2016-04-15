using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;

using DataProvider;

namespace Demo.Web.Areas.Sys.Controllers
{
    public class OrangizeController : Controller
    {
        // GET: Sys/Orangize
        public ActionResult Index()
        {
            return View();
        }
    }
    public class OrangizeApiController : ApiController
    {
        public IEnumerable<Orangize> Get()
        {
            string query = "select * from Autofac.Orangize ";
            var list = dapperUtil.Query<Orangize>(query).ToList();
            return list;
        }
    }
}