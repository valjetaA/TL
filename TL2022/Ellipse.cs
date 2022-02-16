namespace TL2022
{
    public class Ellipse
    {
        public Point CenterPoint { get; private set; }
        public int MinorAxis { get; private set; }
        public int MajorAxis { get; private set; }

        public Ellipse(Point centerpoint, int minoraxis, int majoraxis )
        {
            if (minoraxis <= 0)
            {
                throw new ArgumentException("Minor semiaxis of ellipse cannot take values ​​less than or equal to 0");
            }
            if (majoraxis <= 0)
            {
                throw new ArgumentException("Major semiaxis of ellipse cannot take values ​​less than or equal to 0");
            }

            CenterPoint = centerpoint;
            MinorAxis = minoraxis;
            MajorAxis = majoraxis;
        }

        public double GetSquare()
        {
            return Math.Round(Math.PI * MinorAxis * MajorAxis);
        }
        public double GetLength()
        {
            return Math.Round(Math.PI * (MinorAxis + MajorAxis));
        }
    }
}
