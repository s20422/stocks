﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Shared.DTOs.Tickers
{
    public class Api_OpenCloseResponseDTO
    {
        public double V { get; set; }
        public double Vw { get; set; }
        public double O { get; set; }
        public double C { get; set; }
        public double H { get; set; }
        public double L { get; set; }
        public double T { get; set; }
        public int N { get; set; }
       
    }
}