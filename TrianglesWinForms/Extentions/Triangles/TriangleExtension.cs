using Triangles.Models;

namespace TrianglesWinForms.Extentions.Triangles
{
    public static class TriangleExtension
    {
        public static bool CheckIsAncestor(this Triangle ancestor, Triangle child) =>
            Functions.ChecTrianglesRelation(ancestor, child);

        public static bool CheckForIntersection(this Triangle curent, Triangle triangle) =>
            Functions.CheckIsTrianglesIntersect(curent, triangle) 
            || Functions.CheckIsTrianglesIntersect(triangle, curent);
    }
}
