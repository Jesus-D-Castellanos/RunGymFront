﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunGymFront.Services
{
    public static class SessionHelper
    {
        public static string BearerToken
        {
            get => HttpContext.Current.Session["Token"] as string;
            set => HttpContext.Current.Session["Token"] = value;
        }

        public static string UserName
        {
            get => HttpContext.Current.Session["Username"] as string;
            set => HttpContext.Current.Session["Username"] = value;
        }
    }
}