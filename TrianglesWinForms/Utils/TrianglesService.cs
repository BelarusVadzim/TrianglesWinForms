using Triangles.Models;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesService
    {
        private readonly TrianglesDataService trianglesDataService;
        private readonly TrianglesDataValidator trianglesDataValidator;

        public TrianglesService()
        {
            trianglesDataService = new TrianglesDataService();
            trianglesDataValidator = new TrianglesDataValidator();
        }

        public async Task<List<Triangle>> GetTrianglesAsync()
        {
            var data = await trianglesDataService.GetTrianglesDataAsync();

            TrianglesDataValidator.Validate(data);

            return data
                .Coordinates
                .Select(x => BuildTrianglesPoints(x))
                .Select(x => new Triangle(x))
                .ToList();
        }

        private List<Point> BuildTrianglesPoints(int[] coordinates) 
        {
            var points = new List<Point>();

            for (var i = 0; i < 6; i += 2)
            {
                points.Add(new Point(coordinates[i], coordinates[i + 1]) );
            }

            return points;
        }
    }
}
