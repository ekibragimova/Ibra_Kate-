using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PhotoEnhancer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();

            mainForm.AddFilter(new PixelFilter<LighteningParameters>(
                "Осветление/затемнение",
                (pixel, parameters) => pixel * parameters.Coefficient));
            
            mainForm.AddFilter(new PixelFilter<EmptyParameters>(
                "Оттенки серого",
                (pixel, parameters) =>
                {
                    var lightness = 0.3 * pixel.R + 0.6 * pixel.G + 0.1 * pixel.B;
                    return new Pixel(lightness, lightness, lightness);
                }));

            mainForm.AddFilter(new PixelFilter<NoiseParameters>(
                "Шум",
                (pixel, parameters) =>
                {
                    Random rnd = new Random();
                    double rr = rnd.NextDouble();
                    double rg = rnd.NextDouble();
                    double rb = rnd.NextDouble();
                    return new Pixel(parameters.NoiseIntensity * rr + (1 - parameters.NoiseIntensity) * pixel.R,
                    parameters.NoiseIntensity * rg + (1 - parameters.NoiseIntensity) * pixel.G,
                    parameters.NoiseIntensity * rb + (1 - parameters.NoiseIntensity) * pixel.B);
                }));

            mainForm.AddFilter(new TransformFilter(
                "Отражение по горизонтали",
                size => size,
                (point, size) => new Point(size.Width - point.X - 1, point.Y)
                ));

            mainForm.AddFilter(new TransformFilter(
                "Поворот на 90° против ч. с.",
                size => new Size(size.Height, size.Width),
                (point, size) => new Point(size.Width - point.Y - 1, point.X)
                ));

            mainForm.AddFilter(new TransformFilter(
                "Транспонирование",
                size => new Size(size.Height, size.Width),
                (point, size) => new Point(point.Y, point.X)
                ));

            mainForm.AddFilter(new TransformFilter<RotationParameters>(
                "Поворот на произвольный угол",
                new RotateTransformer()
                ));

            mainForm.AddFilter(new TransformFilter<ShiftUpParameters>(
                "Сдвиг вверх",
                new ShiftUpTransformer()
                ));

            Application.Run(mainForm);
        }
    }
}
