using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDemo.Entity
{
    public class Users
    {
        public Users()
        {
            Roles = new List<Role>();
        }
        public int UserID { set; get; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserNickName { get; set; }
        public List<Role> Roles { get; set; }

    }
}
