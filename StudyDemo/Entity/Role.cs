using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDemo.Entity
{
    public class Role
    {
        public Role()
        {
            Users = new List<User>();
        }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleNickName { get; set; }
        public List<User> Users { get; set; }
    }
}
