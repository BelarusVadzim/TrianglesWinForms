using TrianglesWinForms.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static partial class Functions
    {
        private static bool CheckIsPointBelongsToSegment(Segment segment, Point point)
        {
            var segmentLength = segment.GetLength();
            var segment1 = new Segment{ A = segment.A, B = point }.GetLength();
            var segment2 = new Segment{ A = segment.B, B = point }.GetLength();

            return segment1 + segment2 <= segmentLength;
        }
    }
}
