﻿using DesignPatternsASP.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace DesignPatternsASP.Setups
{    
    public class MySetups
    {
        public MySetups()
        {

        }

        public string PathLog2 { get; set; }
        public decimal LocalPercentage { get; set; }
        public decimal ForeignPercentage { get; set; }
        public decimal Extra { get; set; }

    }
}
