﻿using System.Web;
using System.Web.Mvc;

namespace AngularJS_Asp.NET_MVC_5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
