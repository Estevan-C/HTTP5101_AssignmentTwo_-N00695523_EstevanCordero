﻿using System.Web;
using System.Web.Mvc;

namespace HTTP5101_AssignmentTwo_EstevanCordero
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
