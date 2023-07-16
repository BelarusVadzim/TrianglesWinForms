using Triangles.Models;
using Triangles.Utils;
using TrianglesWinForms.Models;
using TrianglesWinForms.Models.Factories;
using TrianglesWinForms.Utils;
using TrianglesWinForms.ViewModels;
using TrianglesWinForms.ViewModels.Factories;

namespace TrianglesWinForms.Operations
{
    public class GetTrianglesViewModelOperation
    {
        private readonly TrianglesViewModelFactory trianglesViewModelFactory;
        private readonly TrianglesRender trianglesRender;
        private readonly TrianglesOrganizer trianglesOrganizer;
        private readonly TrianglesValidator trianglesValidator;
        private readonly TrianglesService trianglesService;
        private readonly TrianglesGenerationCounter trianglesGenerationCounter;
        private readonly InfoTextFactory infoTextFactory;


        public GetTrianglesViewModelOperation()
        {
            trianglesViewModelFactory = new TrianglesViewModelFactory();
            trianglesRender = new TrianglesRender();
            trianglesOrganizer = new TrianglesOrganizer();
            trianglesValidator = new TrianglesValidator();
            trianglesService = new TrianglesService();
            trianglesGenerationCounter = new TrianglesGenerationCounter();
            infoTextFactory = new InfoTextFactory();
        }
        public async Task<TrianglesViewModel> ExecuteAsync()
        {
            List<Triangle> triangles;

            try
            {
                triangles = await trianglesService.GetTrianglesAsync();
            }
            catch (Exception ex) 
            {
                return trianglesViewModelFactory.Create(ex.Message);
            }

            var validationResult = trianglesValidator.Validate(triangles);

            if(validationResult.Success)
            {
                var organizedTriangles = trianglesOrganizer.Organize(triangles);
                var renderedTriangles = trianglesRender.Render(organizedTriangles);
                var info = infoTextFactory.Create(organizedTriangles);

                return trianglesViewModelFactory.Create(renderedTriangles, info);
            }

            return trianglesViewModelFactory.Create(validationResult.Message!);
        }
    }
}
