using Triangles.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static partial class Functions
    {
        public static bool CheckTrianglesRelation(Triangle ancestor, Triangle child)
        {
            ArgumentNullException.ThrowIfNull(ancestor, nameof(ancestor));
            ArgumentNullException.ThrowIfNull(child, nameof(child));

            var points = new[] { child.A, child.B, child.C };

            var isPointInsideTriangle = points.Select(p =>
              CheckIsPointInsideTriangle(ancestor, p)
            );

            return isPointInsideTriangle.Aggregate(true,(res, cur) => res && cur);
        }
    }
}
