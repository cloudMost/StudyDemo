using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Demo.Web.Areas.Sys.Controllers
{
    public class UsersController : Controller
    {
        // GET: Sys/Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DataTable()
        {
            return View();
        }
    }
    public class UsersApiController : ApiController
    {
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetUsers()
        {
            string json= JsonConvert.SerializeObject(GetData()); 
            HttpResponseMessage re = new HttpResponseMessage();
            re.Content = new StringContent(json, Encoding.GetEncoding("UTF-8"), "application/json");
            return re;
        }

        public List<DataProvider.Users> GetData()
        {
            List<DataProvider.Users> list = new List<DataProvider.Users>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(new DataProvider.Users { UserID = i+1, UserName = "xiaohong"+i, UserNickName = "小红", UserPassword = "123456" });   
            }
            return list;
        }
    }
}