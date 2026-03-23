using System;
using LineLib;

namespace LineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment s1 = new Segment(0, 0, 3, 4);
            Segment s2 = new Segment(s1);

            Console.WriteLine("Segment:");
            Console.WriteLine(s1.GetSegmentInfo());

            Console.WriteLine("Length: " + s1.Length());
            Console.WriteLine("Angle with OX: " + s1.AngleWithOX());

            Console.WriteLine("\nCopy:");
            Console.WriteLine(s2.GetSegmentInfo());
        }
    }
}