﻿using System.Web;
using System.Web.Mvc;

namespace B05ASPC08_w01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
