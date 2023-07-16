using Triangles.Models;
using TrianglesWinForms.Extentions.Triangles;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesOrganizer
    {
        public List<Triangle> Organize(List<Triangle> triangles)
        {
            ArgumentNullException.ThrowIfNull(triangles, nameof(triangles));

            var organizedTriangles = new List<Triangle>();

            while (triangles.Count > 0)
            {
                var root = GetRoot(triangles);
                triangles = ExcludeTriangle(triangles, root);

                AddChild(organizedTriangles, root);
            }

            return organizedTriangles;
        }

        private void AddChild(List<Triangle> triangles, Triangle triangle)
        {
            //If there is no any triangles we should add current one in the list
            if (triangles.Count == 0)
            {
                triangles.Add(triangle);
                return;
            }

            //If there are more then 0 we have to check childrens of each triangle in the array
            for (var i = 0; i < triangles.Count; i++)
            {
                if (triangles[i].CheckIsAncestor(triangle))
                {
                    triangle.Parent = triangles[i];
                    AddChild(triangles[i].Children, triangle);
                    return;
                }
            }

            //If there is no any parent trinagle in array then the current one is sibling and we have to add it in the current array
            triangles.Add(triangle);
        }

        private Triangle GetRoot(List<Triangle> triangles) 
        {
            var triangle = triangles[0];

            if (triangles.Count > 1)
            {
                for (var i = 1; i < triangles.Count; i++)
                {
                    if (triangles[i].CheckIsAncestor(triangle))
                        triangle = triangles[i];
                }
            }

            return triangle;
        }

        private List<Triangle> ExcludeTriangle(IEnumerable<Triangle> triangles, Triangle triangle ) =>
            triangles.Where(t => t.A != triangle.A || t.B != triangle.B || t.C != triangle.C).ToList();
    }
}
