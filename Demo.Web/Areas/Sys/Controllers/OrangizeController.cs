using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        public ActionResult AddOrangize()
        {
            return View();
        }
        public ActionResult JS()
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
        [System.Web.Http.HttpPost]
        public string Add(dynamic obj)
        {


            return null;
            //Orangize o = JsonConvert.DeserializeObject<Orangize>();
            //string query = "insert into Autofac.Orangize(ORANGIZECODE,ORANGIZENAME,ORANGIZENICKNAME) values(@ORANGIZECODE,@ORANGIZENAME,@ORANGIZENICKNAME)";

            //dapperUtil.AddOrUpdate(query,);
        }
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <returns></returns>
        public string AddImage(HttpPostedFile file)
        {
            
            return null;

        }
    }
}