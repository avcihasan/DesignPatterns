﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services.Abstracts
{
    public interface IStockService
    {
        void Buy();
        void Sell();
    }
}
