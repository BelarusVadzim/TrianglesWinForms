using Triangles.Models;
using TrianglesWinForms.Extentions.Triangles;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesValidator
    {
        public Models.ValidationResult Validate(List<Triangle> triangles) 
        {
            for (var i = 0; i < triangles.Count - 1; i++)
            {
                for (var n = i + 1; n < triangles.Count; n++)
                {
                    if (triangles[n].CheckForIntersection(triangles[i]))
                    {
                        return new Models.ValidationResult 
                        { 
                            Success = false, 
                            Message = $"triangles {triangles[n]} and {triangles[i]} intersect" 
                        };
                    }
                }
            }

            return new Models.ValidationResult { Success = true };
        }
    }
}
