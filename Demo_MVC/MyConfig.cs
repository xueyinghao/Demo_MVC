using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Text;

namespace Demo_MVC
{
    public class MyConfig:Entities
    {
        //封装EF实体模型
        public System.Data.Entity.DbContext db { get; private set; }
    }
}