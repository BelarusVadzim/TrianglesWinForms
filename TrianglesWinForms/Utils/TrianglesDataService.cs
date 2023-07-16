using TrianglesWinForms.Models;
using TrianglesWinForms.Models.Factories;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesDataService
    {
        private readonly TrianglesDataFactory trianglesDataFactory;

        public TrianglesDataService()
        {
            trianglesDataFactory = new TrianglesDataFactory();
        }

        public async Task<TrianglesData> GetTrianglesDataAsync()
        {
            string[] lines = await File.ReadAllLinesAsync("triangles.dat");

            return trianglesDataFactory.Create(lines);
        }
    }
}
