using MyPhotoshop.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class TransformFilter: TransformFilter<EmptyParameters>
        //where TParameters : IParameters, new()
    {
        public TransformFilter(string name, Func<Size, Size> sizeTransformer, Func<Point, Size, Point> pointTransformer)
            : base(name, new FreeTransformer(sizeTransformer, pointTransformer)) { }
    }
}
