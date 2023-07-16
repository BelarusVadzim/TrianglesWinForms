namespace Triangles.Models
{
    public class Triangle
    {
        public Triangle() { }

        public Triangle(List<Point> points)
        {
            A = points[0];
            B = points[1];
            C = points[2];
        }

        public Point A { get; set; }

        public Point B { get; set; }

        public Point C { get; set; }

        public List<Triangle> Children { get; set; } = new List<Triangle>();

        public Triangle? Parent { get; set; }

        public Point[] Points { get => new[] { A, B, C }; }

        public override string ToString()
        {
            return $"{A}; {B}; {C} ";
        }
    }
}
