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
            const string FileName = "triangles.dat";

            string[] lines;

            try
            {
                lines = await File.ReadAllLinesAsync(FileName);
            }
            catch(FileNotFoundException) 
            {
                throw new FileNotFoundException($"File {FileName} not found");
            }

            return trianglesDataFactory.Create(lines);
        }
    }
}
