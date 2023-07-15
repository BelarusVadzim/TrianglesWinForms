using System.Drawing.Drawing2D;
using Triangles.Models;

namespace Triangles.Utils
{
    internal class TrianglesRender
    {
        public Bitmap Render(List<Triangle> triangles)
        {
            const int Width = 500;
            const int Height = 300;
            
            var triangleColor = Color.FromArgb(128, 128, 200, 150);
            var backgroundColor = Color.FromArgb(255, 255, 255);
            var bitmap = new Bitmap(Width, Height);

            using (var gfx = Graphics.FromImage(bitmap))
            using (var brush = new SolidBrush(backgroundColor))
            {
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.FillRectangle(brush, 0, 0, Width, 300);

                brush.Color = triangleColor;

                RenderTriangles(triangles, gfx, brush);
            }

            return bitmap;
        }

        private void RenderTriangles(List<Triangle> triangles, Graphics gfx, SolidBrush brush)
        {
            triangles.ForEach(triangle =>
            {
                gfx.FillPolygon(brush, triangle.Points);
                RenderTriangles(triangle.Children, gfx, brush);
            });
        }
    }
}
