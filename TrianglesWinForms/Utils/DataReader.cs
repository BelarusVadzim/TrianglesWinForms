using TrianglesWinForms.Models;
using TrianglesWinForms.Models.Factories;

namespace TrianglesWinForms.Utils
{
    public sealed class DataReader
    {
        private readonly TrianglesDataFactory trianglesDataFactory;

        public DataReader()
        {
            trianglesDataFactory = new TrianglesDataFactory();
        }

        public async Task<TrianglesData> GetTrianglesData()
        {
            string[] lines = await File.ReadAllLinesAsync("triangles.dat");

            return trianglesDataFactory.Create(lines);
        }

        private TrianglesData

    }
}
