using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi
{
    public static class ApplicationLogger
    {
        public static readonly ILog Logger = LogManager.GetLogger("WebApi");
    }
}