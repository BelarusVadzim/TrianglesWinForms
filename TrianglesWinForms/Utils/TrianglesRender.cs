using System.Drawing.Drawing2D;
using Triangles.Models;

namespace Triangles.Utils
{
    public sealed class TrianglesRender
    {
        const int MaxCanvasX = 2000;
        const int MaxCanvasY = 2000;

        public Bitmap Render(List<Triangle> triangles)
        {
            ArgumentNullException.ThrowIfNull(triangles, nameof(triangles));

            var maxCoordinates = GetMaxCoordinates(triangles);
            var autoScale = GetAutoScale(maxCoordinates);

            var canvasSize = GetCanvasSize(maxCoordinates, autoScale);

            var Width = canvasSize.X;
            var Height = canvasSize.Y;

            var triangleColor = Color.FromArgb(128, 128, 200, 128);
            var triangleBorderColor = Color.FromArgb(100, 128, 100);
            var bitmap = new Bitmap(Width, Height);

            using (var gfx = Graphics.FromImage(bitmap))
            using (var brush = new SolidBrush(triangleColor))
            using (var pen = new Pen(triangleBorderColor))
            {
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                RenderTriangles(triangles, gfx, brush, pen, autoScale);
            }

            return bitmap;
        }

        private void RenderTriangles(List<Triangle> triangles, Graphics gfx, SolidBrush brush, Pen pen, int scale)
        {
            triangles.ForEach(triangle =>
            {
                var points = scale != 1
                    ? triangle.Points.Select(p => new Point(p.X * scale, p.Y * scale)).ToArray()
                    : triangle.Points;

                gfx.FillPolygon(brush, points);
                gfx.DrawPolygon(pen, points);
                RenderTriangles(triangle.Children, gfx, brush, pen, scale);
            });
        }

        private static Point GetMaxCoordinates(List<Triangle> triangles) =>
            new (
                 triangles.Max(tr => tr.Points.Max(p => p.X)),
                 triangles.Max(tr => tr.Points.Max(p => p.Y))
                );

        private static Point GetCanvasSize(Point maxCoordinates, int scale ) =>
            new(maxCoordinates.X * scale, maxCoordinates.Y * scale);

        private static int GetAutoScale(Point canvasSize)
        {
            var scaleX = MaxCanvasX / canvasSize.X;
            var scaleY = MaxCanvasY / canvasSize.Y;
            
            return scaleX > scaleY ? scaleY : scaleX;
        }
    }
}
