namespace LineLib
{
    public class Segment : Line
    {
        public Segment() : base()
        {
        }

        public Segment(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {
        }

        public Segment(Segment other) : base(other)
        {
        }

        public double AngleWithOX()
        {
            return System.Math.Atan2(y2 - y1, x2 - x1);
        }

        public string GetSegmentInfo()
        {
            return GetInfo();
        }
    }
}