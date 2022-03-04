using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class RotationParameters : IParameters
    {
        public double Angle { get; set; }
        public ParameterInfo[] GetDescriptions()
        {
            return new[]
            {
                new ParameterInfo{Name="Угол", MaxValue=360, MinValue=0, Increment=15, DefaultValue=0}
            };
        }

        public void SetValues(double[] values)
        {
            Angle = values[0];
        }
    }
}
