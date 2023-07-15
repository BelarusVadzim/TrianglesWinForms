namespace Triangles.Models
{
    public class Triangle
    {
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
