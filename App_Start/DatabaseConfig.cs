using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgentyApplication.App_Start
{
    public class DatabaseConfig
    {
        public static LiteDatabase Db { get; set; }
        public static void ConfigureDatabase()
        {
            Db = new LiteDatabase("MyResume.db");
        }
    }
}