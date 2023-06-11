using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class ShiftUpTransformer : ITransformer<ShiftUpParameters>
    {
        double border { get; set; }

        public Size ResultSize { get; private set; }

        public void Initialize(Size size, ShiftUpParameters parameters)
        {
            ResultSize = size;
            border = size.Height - Math.Round(parameters.ShiftPercent/100 * size.Height);
        }

        public Point? MapPoint(Point point)
        {
            int x, y;
            x = point.X;
            if (point.Y < border)
                y = point.Y + (int)(ResultSize.Height - border);
            else
                y = point.Y - (int)border;

            if (y < 0 || y >= ResultSize.Height)
                return null;

            return new Point(x, y);
        }
    }
}
