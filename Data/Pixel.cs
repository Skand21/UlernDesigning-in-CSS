using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {

        public Pixel(double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.r = r;
            this.g = g;
            this.b = b;
        }


        double r;

        public double R
        {
            get { return r; }
            set
            {

                r = Check(value);
            }
        }

        double g;
        public double G
        {
            get { return g; }
            set
            {
                g = Check(value);
            }
        }
        double b;
        public double B
        {
            get { return b; }
            set
            {
                b = Check(value);
            }
        }


        public double Check(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }

        public static Pixel operator *(Pixel p, double c)
        {
            return new Pixel(
                              Pixel.Trim(p.R * c),
                              Pixel.Trim(p.G * c),
                              Pixel.Trim(p.B * c));
        }

    }
}
