using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    public class NoiseFilter : PixelFilter
    {
        public override ParameterInfo[] GetParametersInfo()
        {
            return new[]
{
                new ParameterInfo()
                {
                    Name = "Интенсивность шума",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.01
                }
            };
        }

        public override Pixel ProcessPixel(Pixel pixel, double[] parameters)
        {
            Random rnd = new Random();
            double rr = rnd.Next(0,1);
            double rg = rnd.Next(0, 1);
            double rb = rnd.Next(0, 1);
            return new Pixel(parameters[0] * rr + (1 - parameters[0]) * pixel.R,    
                    parameters[0] * rg + (1 - parameters[0]) * pixel.G,
                    parameters[0] * rb + (1 - parameters[0]) * pixel.B);
        }

        public override string ToString()
        {
            return "Шум";
        }

    }
}
