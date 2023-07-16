namespace TrianglesWinForms.ViewModels.Factories
{
    public sealed class TrianglesViewModelFactory
    {
        public TrianglesViewModel Create(Bitmap renderedTriangles, string infoText) =>
            new() { RenderedTriangles = renderedTriangles, Info = infoText, HasErrors = false };

        public TrianglesViewModel Create(string? infoText) =>
            new() { Info = infoText ?? "Unknown error", HasErrors = true };
    }
}
