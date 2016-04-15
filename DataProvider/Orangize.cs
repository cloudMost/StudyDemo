using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class Orangize
    {
        public string OrangizeCode { get; set; }
        public string OrangizeName { get; set; }
        public string OrangizeNickName { get; set; }
        public virtual List<User> Users { get; set; }
        public string ParentCode { get; set; }

    }
}
