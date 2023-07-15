namespace TrianglesWinForms.Models
{
    public struct Segment
    {
        public Point A { get; set; }

        public Point B { get; set; }

        public double GetLength() =>
            Math.Sqrt(Math.Abs(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)));
    }
}
