using Triangles.Models;
using TrianglesWinForms.Utils;

namespace TrianglesWinForms.ViewModels.Factories
{
    public sealed class InfoTextFactory
    {
        private readonly TrianglesGenerationCounter trianglesGenerationCounter;

        public InfoTextFactory()
        {
            trianglesGenerationCounter = new TrianglesGenerationCounter();
        }

        public string Create(IEnumerable<Triangle> OrganizedTriangles) 
        {
            ArgumentNullException.ThrowIfNull(OrganizedTriangles, nameof(OrganizedTriangles));

            var generationAmount = trianglesGenerationCounter.Count(OrganizedTriangles);

            return $"Number of shades: {generationAmount}";
        }
    }
}
