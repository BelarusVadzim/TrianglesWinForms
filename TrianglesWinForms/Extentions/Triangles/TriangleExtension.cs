using Triangles.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static class TriangleExtension
    {
        public static bool CheckIsAncestor(this Triangle ancestor, Triangle child)
        {
            ArgumentNullException.ThrowIfNull(ancestor, nameof(ancestor));
            ArgumentNullException.ThrowIfNull(child, nameof(child));

            return Functions.CheckTrianglesRelation(ancestor, child);
        }

        public static bool CheckForIntersection(this Triangle curent, Triangle triangle)
        {
            ArgumentNullException.ThrowIfNull(curent, nameof(curent));
            ArgumentNullException.ThrowIfNull(triangle, nameof(triangle));

            return Functions.CheckIsTrianglesIntersect(curent, triangle)
            || Functions.CheckIsTrianglesIntersect(triangle, curent);
        }
    }
}
