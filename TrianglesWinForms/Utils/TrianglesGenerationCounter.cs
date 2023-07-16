using Triangles.Models;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesGenerationCounter
    {
        public int Count(IEnumerable<Triangle> triangles, int generation = 1) 
        {
            var nextGeneration = triangles
                .Where((x) => x.Children.Count > 0)
                .Select((x) => x.Children)
                .SelectMany(x => x)
                .ToArray();

            if (nextGeneration.Length > 0)
            {
                generation++;
                return Count(nextGeneration, generation);
            }

            return generation;
        }
    }
}
