﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    public class FreeTransformer : ITransformer<EmptyParameters>
    {
        Func<Size, Size> sizeTransformer;
        Func<Point, Size, Point> pointTransformer;

        Size oldSize;

        public FreeTransformer(Func<Size, Size> sizeTransformer, Func<Point, Size, Point> pointTransformer)
        {
            this.sizeTransformer = sizeTransformer;
            this.pointTransformer = pointTransformer;
        }
        public Size ResultSize { get;private set;}

        public void Prepare(Size size, EmptyParameters parameters)
        {
            oldSize = size;
            ResultSize = sizeTransformer(oldSize);
        }

        public Point? MapPoint(Point newPoint)
        {
            return pointTransformer(newPoint, oldSize);
        }

    }
}
