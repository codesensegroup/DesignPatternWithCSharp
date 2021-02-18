using System;
using System.Collections;
using System.Collections.Generic;

namespace Adapter
{
    public class LineToPointAdapter : IEnumerable<Point>
    {
        private static int count = 0; 
        private int hash;

        static Dictionary<int, List<Point>> cache = new Dictionary<int, List<Point>>();

        public LineToPointAdapter(Line line)
        {
            hash = line.GetHashCode();
            if (cache.ContainsKey(hash)) return; // we already have it

            Console.WriteLine($"{++count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}] (with caching)");
            //                                                 ^^^^

            var points = new List<Point>();

            int leftPoint = Math.Min(line.Start.X, line.End.X);
            int rightPoint = Math.Max(line.Start.X, line.End.X);
            
            int topPoint = Math.Min(line.Start.Y, line.End.Y);
            int bottomPoint = Math.Max(line.Start.Y, line.End.Y);
            
            int distanceX = rightPoint - leftPoint;
            int distanceY = line.End.Y - line.Start.Y;

            if (distanceX == 0)
            {
                //Add vertical point
                for (int y = topPoint; y <= bottomPoint; ++y)
                {
                    points.Add(new Point(leftPoint, y));
                }
            }
            else if (distanceY == 0)
            {
                //Add horizontal point
                for (int x = leftPoint; x <= rightPoint; ++x)
                {
                    points.Add(new Point(x, topPoint));
                }
            }

            cache.Add(hash, points);
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return cache[hash].GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
