using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDemo
{
    public class Command<TEntity> where TEntity:class
    {
        public string sql { get; set; }
        public TEntity model { get; set; }
    }
}
