﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class ProfitChartScannerInitializedException : Exception
    {
        public ProfitChartScannerInitializedException(string message) : base(message) { }
    }
}
