﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class HostingUnit
    {
        public long HostingUnitKey = 10000000;
        public long NumHostingUnit { get; set; }
        public Host Owner{ get; set; }
        public string HostingUnitName { get; set; }
        public bool[,] Diary = new bool[12, 31];
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}