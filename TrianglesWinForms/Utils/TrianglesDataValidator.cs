using System.ComponentModel.DataAnnotations;
using TrianglesWinForms.Models;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesDataValidator
    {
        public static void Validate(TrianglesData trianglesData) 
        {
            ArgumentNullException.ThrowIfNull(trianglesData, nameof(trianglesData));

            if (trianglesData.Coordinates.Any(x => x.Length != 6 || x.Any(c => c < 0 || c > 1000)))
                throw new ValidationException("Invalid triangle coordinates");
        }
    }
}
