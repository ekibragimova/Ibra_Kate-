﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class NoiseParameters : IParameters
    {
        [ParameterInfo(Name = "Интенсивность шума",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.01)]
        public double NoiseIntensity { get; set; }
    }
}
