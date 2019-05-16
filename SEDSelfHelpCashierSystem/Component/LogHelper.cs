﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace SEDSelfHelpCashierSystem.Component
{
    public class LogHelper
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ILog test = LogManager.GetLogger("ErrorLogFileAppender");
    }
}
