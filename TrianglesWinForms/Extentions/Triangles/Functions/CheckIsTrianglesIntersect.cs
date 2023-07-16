using Triangles.Models;
using TrianglesWinForms.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static partial class Functions
    {
        public static bool CheckIsTrianglesIntersect(Triangle triangle1, Triangle triangle2)
        {
            ArgumentNullException.ThrowIfNull(triangle1, nameof(triangle1));
            ArgumentNullException.ThrowIfNull(triangle2, nameof(triangle2));

            var points = new List<Point> { triangle2.A, triangle2.B, triangle2.C };
            var segments = new List<Segment>
            {
                new Segment {A = triangle1.A, B = triangle1.B },
                new Segment {A = triangle1.B, B = triangle1.C },
                new Segment {A = triangle1.C, B = triangle1.A },
            };

            var isPointBelogToTriangleSegment = false;

            segments.ForEach((s) =>
              points.ForEach((p) => isPointBelogToTriangleSegment 
              = isPointBelogToTriangleSegment || CheckIsPointBelongsToSegment(s, p))
            );

            if (isPointBelogToTriangleSegment) return true;

            var isPointInsideTriangle = points.Select((p) =>
              CheckIsPointInsideTriangle(triangle1, p)
            ).ToArray();

            //Checking if all points are inside the triangle or all outside it. If yes, then the triangles do not intersect.
            return !(isPointInsideTriangle.All(x => x) || isPointInsideTriangle.All(x => !x));
        }
    }
}
