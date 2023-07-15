namespace TrianglesWinForms.ViewModels
{
    public sealed class TrianglesViewModel
    {
        public Bitmap? RenderedTriangles { get; set; }

        public bool HasErrors { get; set; }

        public string Info { get; set; } = string.Empty;
    }
}
