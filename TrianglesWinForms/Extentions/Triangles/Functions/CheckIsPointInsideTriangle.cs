using Triangles.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static partial class Functions
    {
        private static bool CheckIsPointInsideTriangle(Triangle triangle, Point point)
        {
            var IsPointInSameHalfPlaneAsTriangle1 = (triangle.A.X - point.X) * (triangle.B.Y - triangle.A.Y)
                - (triangle.B.X - triangle.A.X) * (triangle.A.Y - point.Y) > 0;
            var IsPointInSameHalfPlaneAsTriangle2 = (triangle.B.X - point.X) * (triangle.C.Y - triangle.B.Y)
                - (triangle.C.X - triangle.B.X) * (triangle.B.Y - point.Y) > 0;
            var IsPointInSameHalfPlaneAsTriangle3 = (triangle.C.X - point.X) * (triangle.A.Y - triangle.C.Y)
                - (triangle.A.X - triangle.C.X) * (triangle.C.Y - point.Y) > 0;


            return IsPointInSameHalfPlaneAsTriangle1
                && IsPointInSameHalfPlaneAsTriangle2
                && IsPointInSameHalfPlaneAsTriangle3
                ||
                !IsPointInSameHalfPlaneAsTriangle1
                && !IsPointInSameHalfPlaneAsTriangle2
                && !IsPointInSameHalfPlaneAsTriangle3;
        }
    }
}
