using Triangles.Models;
using Triangles.Utils;
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

        public GetTrianglesViewModelOperation()
        {
            trianglesViewModelFactory = new TrianglesViewModelFactory();
            trianglesRender = new TrianglesRender();
            trianglesOrganizer = new TrianglesOrganizer();
            trianglesValidator = new TrianglesValidator();
        }
        public TrianglesViewModel Execute()
        {
            var triangle = new Triangle { A = new Point(0, 0), B = new Point(20, 100), C = new Point(40, 0) };
            var triangle2 = new Triangle { A = new Point(10, 0), B = new Point(30, 100), C = new Point(50, 0) };
            var triangleChild1 = new Triangle { A = new Point(11, 1), B = new Point(30, 50), C = new Point(49, 1) };
            //triangle2.Children.Add(triangleChild1);
            var triangles = new List<Triangle> { triangle, triangle2, triangleChild1 };

            var validationResult = trianglesValidator.Validate(triangles);


            var organizedTriangles = trianglesOrganizer.Organize(triangles);


            var renderedTriangles = trianglesRender.Render(organizedTriangles);

            var view = trianglesViewModelFactory.Create(renderedTriangles, "info test");

            return view;
        }
    }
}
