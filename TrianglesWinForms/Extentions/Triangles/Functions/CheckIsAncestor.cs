using Triangles.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static partial class Functions
    {
        public static bool ChecTrianglesRelation(Triangle ancestor, Triangle child)
        {
            var points = new[] { child.A, child.B, child.C };

            var isPointInsideTriangle = points.Select(p =>
              CheckIsPointInsideTriangle(ancestor, p)
            );

            return isPointInsideTriangle.Aggregate(true,(res, cur) => res && cur);
        }
    }
}
