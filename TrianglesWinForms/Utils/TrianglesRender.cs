using System.Drawing.Drawing2D;
using Triangles.Models;

namespace Triangles.Utils
{
    internal class TrianglesRender
    {
        public Bitmap Render(List<Triangle> triangles, int scale = 1)
        {
            var canvasSize = GetCanvasSize(triangles, scale);

            var Width = canvasSize.X+10;
            var Height = canvasSize.Y+10;

            var triangleColor = Color.FromArgb(128, 128, 200, 128);
            var backgroundColor = Color.FromArgb(255, 255, 255);
            var bitmap = new Bitmap(Width, Height);

            using (var gfx = Graphics.FromImage(bitmap))
            using (var brush = new SolidBrush(backgroundColor))
            using (var pen = new Pen(triangleColor))
            {
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.FillRectangle(brush, 0, 0, Width, Height);

                brush.Color = triangleColor;

                RenderTriangles(triangles, gfx, brush, pen, scale);
            }

            return bitmap;
        }

        private void RenderTriangles(List<Triangle> triangles, Graphics gfx, SolidBrush brush, Pen pen, int scale)
        {
            triangles.ForEach(triangle =>
            {
                var points = scale != 1
                    ? triangle.Points.Select(p => new Point(p.X * scale, p.Y*scale)).ToArray()
                    : triangle.Points;

                gfx.FillPolygon(brush, points);
                gfx.DrawPolygon(pen, points);
                RenderTriangles(triangle.Children, gfx, brush, pen, scale);
            });
        }

        private Point GetMaxCoordinates(List<Triangle> triangles, Point maxCoordinatesd = new Point())
        {
            var maxX = maxCoordinatesd.X = triangles.Max(tr => tr.Points.Max(p => p.X));
            var maxY = maxCoordinatesd.Y = triangles.Max(tr => tr.Points.Max(p => p.Y));

            maxCoordinatesd.X = maxCoordinatesd.X < maxX ? maxX : maxCoordinatesd.X;
            maxCoordinatesd.Y = maxCoordinatesd.Y < maxY ? maxY : maxCoordinatesd.Y;

            triangles.ForEach(triangle =>
            {
                if (triangle.Children.Any())
                    maxCoordinatesd = GetMaxCoordinates(triangle.Children, maxCoordinatesd);
            });

            return maxCoordinatesd;
        }

        private Point GetCanvasSize(List<Triangle> triangles, int scale)
        {
            var maxCoordinates = GetMaxCoordinates(triangles);

            return new Point(maxCoordinates.X * scale, maxCoordinates.Y * scale);
        }
    }
}
